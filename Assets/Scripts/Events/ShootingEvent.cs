using System;
using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    [Serializable]
    public class ShootingEvent : UnityEvent<Vector2> {}
}