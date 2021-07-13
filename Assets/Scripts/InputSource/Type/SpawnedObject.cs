using Spawn.Pools;
using UnityEngine;

namespace InputSource.Type
{
    public abstract class SpawnedObject : MonoBehaviour
    {
        [SerializeField] private SpawningPool pool;
        
        public virtual void Spawn(Vector2 lookingDirection) {}

        public virtual void Return()
        {
            pool.ReturnObject(this);
        }
    }
}