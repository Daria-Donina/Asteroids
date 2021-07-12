using InputSource.Type;
using Pool;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidsPool : ObjectPool<AsteroidInput>
    {
        [SerializeField]
        private Sprite[] asteroidSprites;
        
        public override AsteroidInput GetObject(Vector3 position)
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