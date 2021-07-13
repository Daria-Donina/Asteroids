using Events;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Serialization;

namespace InputSource.Type
{
    public class Player : MonoBehaviour, IInputSource
    {
        public Vector2 Direction { get; private set; }
        public float RotationAngle { get; private set; }

        public ShootingEvent shotFired = new ShootingEvent();
        public ShootingEvent shotFiredTabStarted = new ShootingEvent();
        public ShootingEvent shotFiredTabEnded = new ShootingEvent();

        private bool _isTabPressed;
        
        private void Update()
        {
            RotationAngle = -Input.GetAxis("Horizontal");
            Direction = transform.up * Mathf.Clamp01(Input.GetAxis("Vertical"));

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                _isTabPressed = !_isTabPressed;
            }

            if (Input.GetButtonDown("Shoot"))
            {
                if (_isTabPressed)
                {
                    shotFiredTabStarted.Invoke(Vector2.zero);
                }
                else
                {
                    shotFired.Invoke(transform.up);
                }
            }

            if (Input.GetButtonUp("Shoot"))
            {
                if (_isTabPressed)
                {
                    shotFiredTabEnded.Invoke(Vector2.zero);
                }
            }
        }
    }
}