using System;
using Components.Shooting;
using Events;
using UnityEngine;

namespace InputSource.Type
{
    public class FlyingSaucer : SpawnedObject, IInputSource 
    {
        public Vector2 Direction { get; set; }
        public float RotationAngle { get; set; } = 0f;

        private Player _player;

        private void Awake()
        {
            _player = FindObjectOfType<Player>();
        }

        private void Update()
        {
            Direction = _player.transform.position - transform.position;
        }
    }
}