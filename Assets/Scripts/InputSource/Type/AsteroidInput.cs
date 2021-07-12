using UnityEngine;

namespace InputSource.Type
{
    public class AsteroidInput : MonoBehaviour, IInputSource
    {
        public float MovingIntensity { get; set; }
        public float RotationAngle { get; set; }
    }
}