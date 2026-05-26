using System;

namespace Exercise_15_Multiple_Interface_Implementation
{
    public interface IControl
    {
        void Play();
        void Pause();
        bool IsPlaying { get; }
    }
}
