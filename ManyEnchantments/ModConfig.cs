using System;
namespace CombineManyRings
{
    public sealed class ModConfig
    {
        public bool AllowSameRing { get; set; } = false;
        public bool BalancedMode { get; set; } = false;
        public bool DestroyRingOnFailure { get; set; } = false;
        public int FailureChancePerExtraRing { get; set; } = 20;
        public int CostPerExtraRing { get; set; } = 100;
    }
}