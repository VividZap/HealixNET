using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SelfHealingSDK.Models;
using SelfHealingSDK.Policies;

namespace SelfHealingSDK
{
    public class SelfHealingManager
    {
        public List<IHealingPolicy> Policies { get; set; } = new List<IHealingPolicy>();
        public List<HealingEvent> HealingLog { get; set; } = new List<HealingEvent>();

        public void RegisterPolicy(IHealingPolicy policy)
        {
            Policies.Add(policy);
        }

        public async Task<T> ExecuteWithHealing<T>(Func<Task<T>> action, string context)
        {
            try
            {
                return await action();
            }
            catch (Exception ex)
            {
                foreach (var policy in Policies)
                {
                    if (policy.CanHandle(ex, context))
                    {
                        var result = await policy.TryHeal<T>(ex, context);
                        HealingLog.Add(new HealingEvent
                        {
                            Time = DateTime.Now,
                            Exception = ex,
                            Context = context,
                            PolicyName = policy.Name,
                            Success = result.isSuccess
                        });
                        if (result.isSuccess)
                            return (T)result.value;
                    }
                }
                throw;
            }
        }
    }
}