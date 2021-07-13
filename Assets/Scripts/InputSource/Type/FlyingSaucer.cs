using System;
using Components.Shooting;
using Events;
using UnityEngine;

namespace InputSource.Type
{
    public class FlyingSaucer : Enemy, IInputSource 
    {
        public Vector2 Direction { get; set; }
        public float RotationAngle { get; set; } = 0f;

        [SerializeField] private int betweenShotsTime;
        [SerializeField] private float shotStartDelay;
        
        private Player _player;
        private ShootingComponent _weapon;

        private void Awake()
        {
            _player = FindObjectOfType<Player>();
            _weapon = GetComponent<ShootingComponent>();
        }

        private void OnEnable()
        {
            InvokeRepeating(nameof(Shoot), shotStartDelay, betweenShotsTime);
        }

        private void OnDisable()
        {
            CancelInvoke();
        }

        private void Update()
        {
            Direction = _player.transform.position - transform.position;
        }

        private void Shoot()
        {
            _weapon.Shoot(_player.transform.position - transform.position);
        }
    }
}