using System;

namespace Exercise_15_Multiple_Interface_Implementation
{
    public interface IVolumeControl : IControl
    {
        void AdjustVolume(int level);
    }
}
