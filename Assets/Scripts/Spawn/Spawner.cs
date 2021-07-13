using System;
using InputSource.Type;
using Pool;
using Spawn.Pools;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Spawn
{
    [RequireComponent(typeof(SpawningPool))]
    public class Spawner : MonoBehaviour
    {
        private SpawningPool _pool;
        
        private void Awake()
        {
            _pool = GetComponent<SpawningPool>();
        }

        public void Spawn(Vector3 position, Vector2 lookingDirection)
        {
            _pool.GetObject(position).Spawn(lookingDirection);
        }
    }
}