using InputSource.Type;
using Spawn.Pools;
using UnityEngine;

namespace Components.Damaging.Type
{
    public class DamagingComponent : MonoBehaviour, IDamagingComponent
    {
        public virtual void OnAttack()
        {
            if (TryGetComponent(out SpawnedObject obj))
            {
                obj.Return();
            }
        }
    }
}