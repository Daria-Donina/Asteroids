using Components.Shooting.Bullets;
using UnityEngine;

namespace Components.Shooting
{
	/// <summary>
	/// Class that allows character to shoot.
	/// </summary>
	public class ShootingComponent : MonoBehaviour
	{
		private BulletPool _bulletPool;

		private void Awake()
		{
			_bulletPool = FindObjectOfType<BulletPool>();
		}

		/// <summary>
		/// Shoots the bullet from character position.
		/// </summary>
		public void Shoot(Vector2 direction)
		{
			var bullet = _bulletPool.GetObject(transform.position);

			bullet.transform.rotation = transform.rotation;
			bullet.gameObject.layer = gameObject.layer;

			bullet.Shoot(direction.normalized);
		}
	}
}