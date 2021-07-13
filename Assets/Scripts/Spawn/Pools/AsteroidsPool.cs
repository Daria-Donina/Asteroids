using InputSource.Type;
using UnityEngine;

namespace Spawn.Pools
{
    public class AsteroidsPool : SpawningPool
    {
        [SerializeField]
        private Sprite[] asteroidSprites;
        
        public override SpawnedObject GetObject(Vector3 position)
        {
            var obj =  base.GetObject(position);
            obj.GetComponent<SpriteRenderer>().sprite = ChooseSprite();
            return obj;
        }

        private Sprite ChooseSprite()
        {
            var index = Random.Range(0, asteroidSprites.Length);
            return asteroidSprites[index];
        }
    }
}