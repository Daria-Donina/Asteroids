using InputSource;
using UnityEngine;

namespace Components.Moving
{
	/// <summary>
	/// Component that allows character to move.
	/// </summary>
	[RequireComponent(typeof(Rigidbody2D))]
	[RequireComponent(typeof(IInputSource))]
	public class MovingComponent : MonoBehaviour
	{
		[SerializeField] private float movingSpeed;
		[SerializeField] private float rotationSpeed;

		private Rigidbody2D _rigidbody;
		private IInputSource _input;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
			_input = GetComponent<IInputSource>();
		}

		private void Update()
		{
			_rigidbody.AddForce(
				transform.up * (_input.MovingIntensity * movingSpeed * Time.deltaTime)
				, ForceMode2D.Force
				);
			
			_rigidbody.MoveRotation(_rigidbody.rotation + _input.RotationAngle * rotationSpeed);
		}
	}
}