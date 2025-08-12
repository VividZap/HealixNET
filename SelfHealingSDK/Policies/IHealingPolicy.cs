using System;
using System.Threading.Tasks;

namespace SelfHealingSDK.Policies
{
    public interface IHealingPolicy
    {
        string Name { get; }
        bool CanHandle(Exception ex, string context);
        Task<(bool isSuccess, object value)> TryHeal<T>(Exception ex, string context);
    }
}