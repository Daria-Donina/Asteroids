using UnityEngine;

namespace InputSource
{
    public interface IInputSource
    {
        public float MovingIntensity { get; set; }
        public float RotationAngle { get; set; }
    }
}