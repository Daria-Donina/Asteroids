using UnityEngine;

namespace InputSource.Type
{
    public abstract class Enemy : MonoBehaviour
    {
        public virtual void Spawn(Vector2 lookingDirection) {}
    }
}