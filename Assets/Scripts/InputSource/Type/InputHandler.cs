using Events;
using UnityEngine;

namespace InputSource.Type
{
    public class InputHandler : MonoBehaviour, IInputSource
    {
        public float MovingIntensity { get; set; }
        public float RotationAngle { get; set; }

        public ShootingEvent shotFired = new ShootingEvent();

        private void Update()
        {
            RotationAngle = -Input.GetAxis("Horizontal");
            MovingIntensity = Mathf.Clamp01(Input.GetAxis("Vertical"));

            if (Input.GetButtonDown("Shoot"))
            {
                shotFired.Invoke();
            }
        }
    }
}