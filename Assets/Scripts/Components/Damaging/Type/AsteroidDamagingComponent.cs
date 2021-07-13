using Spawn.Pools;
using UnityEngine;

namespace Components.Damaging.Type
{
    public class AsteroidDamagingComponent : DamagingComponent
    {
        [SerializeField] private AsteroidsPool fragmentsPool;
        [SerializeField] private int fragmentsAmount;
        
        public override void OnAttack()
        {
            base.OnAttack();

            for (var i = 0; i < fragmentsAmount; ++i)
            {
                fragmentsPool.GetObject(transform.position).Spawn(Vector2.zero);
            }
        }
    }
}