using UnityEngine;

namespace Spawn
{
    public class PeriodicSpawner : Spawner
    {
        [SerializeField] private float startSpawnTime;
        [SerializeField] private int betweenSpawnTime;
        
        [SerializeField] private Transform[] spawnPoints;
        
        private void Start()
        {
            InvokeRepeating(nameof(Spawn), startSpawnTime, betweenSpawnTime);
        }

        public void Spawn()
        {
            var point = spawnPoints[Random.Range(0, spawnPoints.Length)];
            base.Spawn(point.position, point.up);
        }
    }
}