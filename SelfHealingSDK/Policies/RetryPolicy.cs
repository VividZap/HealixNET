using System;
using System.Threading.Tasks;

namespace SelfHealingSDK.Policies
{
    public class RetryPolicy : IHealingPolicy
    {
        public string Name => "Retry Policy";
        private int maxRetries;

        public RetryPolicy(int retries = 3)
        {
            maxRetries = retries;
        }

        public bool CanHandle(Exception ex, string context)
        {
            return true;
        }

        public async Task<(bool isSuccess, object value)> TryHeal<T>(Exception ex, string context)
        {
            int attempts = 0;
            while (attempts < maxRetries)
            {
                try
                {
                    attempts++;

                }
                catch
                {
                }
            }
            return (false, default(T));
        }
    }

}
