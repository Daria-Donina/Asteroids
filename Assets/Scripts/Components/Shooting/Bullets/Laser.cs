using UnityEngine;

namespace Components.Shooting.Bullets
{
    public class Laser : MonoBehaviour
    {
        public void TurnOn()
        {
            gameObject.SetActive(true);
        }

        public void TurnOff()
        {
            gameObject.SetActive(false);
        }
    }
}