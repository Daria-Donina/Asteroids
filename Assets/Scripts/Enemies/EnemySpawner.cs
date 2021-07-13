using System;
using Enemies.Pools;
using InputSource.Type;
using Pool;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Enemies
{
    [RequireComponent(typeof(ObjectPool<Enemy>))]
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float startSpawnTime;
        [SerializeField] private int betweenSpawnTime;
        [SerializeField] private Transform[] spawnPoints;

        private EnemyPool _pool;
        
        private void Awake()
        {
            _pool = GetComponent<EnemyPool>();
        }

        private void Start()
        {
            InvokeRepeating(nameof(Spawn), startSpawnTime, betweenSpawnTime);
        }

        private void Spawn()
        {
            var point = spawnPoints[Random.Range(0, spawnPoints.Length)];
            _pool.GetObject(point.position).Spawn(point.up);
        }
    }
}