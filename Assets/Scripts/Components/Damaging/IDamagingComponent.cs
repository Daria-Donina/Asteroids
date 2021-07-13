namespace Components.Damaging
{
	/// <summary>
	/// Component that makes character vulnerable.
	/// </summary>
	public interface IDamagingComponent
	{
		/// <summary>
		/// An action to perform when character is attacked.
		/// </summary>
		public void OnAttack();
	}
}
