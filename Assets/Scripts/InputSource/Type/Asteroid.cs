using System;
using Enemies.Pools;
using UnityEngine;
using Random = UnityEngine.Random;

namespace InputSource.Type
{
    public class Asteroid : Enemy, IInputSource
    {
        [SerializeField] private float maxLifetime = 5f;

        public Vector2 Direction { get; private set; }
        public float RotationAngle { get; set; } = 0f;

        private const float MINValue = -0.5f;
        private const float MAXValue = 0.5f;

        private AsteroidsPool _pool;

        private void Awake()
        {
            _pool = FindObjectOfType<AsteroidsPool>();
        }

        private void OnEnable()
        {
            Invoke(nameof(Return), maxLifetime);
        }

        private void OnDisable()
        {
            CancelInvoke();
        }

        public override void Spawn(Vector2 lookingDirection)
        {
            Direction = lookingDirection + 
                        new Vector2(
                            Random.Range(MINValue, MAXValue), 
                            Random.Range(MINValue, MAXValue)
                            );
        }

        private void Return()
        {
            _pool.ReturnObject(this);
        }
    }
}