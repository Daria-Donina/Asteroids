using UnityEngine;

namespace InputSource
{
    public interface IInputSource
    {
        public Vector2 Direction { get; }
        public float RotationAngle { get; }
    }
}