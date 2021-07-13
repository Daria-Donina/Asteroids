using System;
using Spawn.Pools;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace InputSource.Type
{
    public class Asteroid : SpawnedObject, IInputSource
    {
        [SerializeField] private float maxLifetime = 5f;
        [SerializeField] private float minValue = -0.5f;
        [SerializeField] private float maxValue = 0.5f;
        
        public Vector2 Direction { get; private set; }
        public float RotationAngle { get; set; } = 0f;
        
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
                            Random.Range(minValue, maxValue), 
                            Random.Range(minValue, maxValue)
                            );
        }
    }
}