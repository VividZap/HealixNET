using System;

namespace SelfHealingSDK.Models
{
    public class HealingEvent
    {
        public DateTime Time { get; set; }
        public Exception Exception { get; set; }
        public string Context { get; set; }
        public string PolicyName { get; set; }
        public bool Success { get; set; }
    }
}