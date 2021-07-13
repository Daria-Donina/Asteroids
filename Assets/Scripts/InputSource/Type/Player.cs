using Events;
using UnityEngine;

namespace InputSource.Type
{
    public class Player : MonoBehaviour, IInputSource
    {
        public Vector2 Direction { get; private set; }
        public float RotationAngle { get; private set; }

        public ShootingEvent shotFired = new ShootingEvent();

        private void Update()
        {
            RotationAngle = -Input.GetAxis("Horizontal");
            Direction = transform.up * Mathf.Clamp01(Input.GetAxis("Vertical"));

            if (Input.GetButtonDown("Shoot"))
            {
                shotFired.Invoke(transform.up);
            }
        }
    }
}