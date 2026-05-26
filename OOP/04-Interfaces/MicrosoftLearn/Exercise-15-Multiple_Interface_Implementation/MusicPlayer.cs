using System;

namespace Exercise_15_Multiple_Interface_Implementation
{
    public class MusicPlayer : ISkipControl, IVolumeControl
    {
        public void Play() { /* Implementation */ }
        public void Pause() { /* Implementation */ }
        public bool IsPlaying { get; private set; }

        public void SkipToNext() { /* Implementation */ }
        public void AdjustVolume(int level) { /* Implementation */ }
    }
}