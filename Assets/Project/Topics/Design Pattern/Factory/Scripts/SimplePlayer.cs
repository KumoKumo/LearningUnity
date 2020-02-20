using System;
using UnityEngine;
namespace ReflectionFactory
{
    internal class SimplePlayer : MonoBehaviour
    {
        [SerializeField] private float health = 100;

        public float Health => health;

        internal void StartFire()
        {
            Debug.Log("Using Fire starter!");
        }

        internal void ChangeHealth(float amount, bool isHeal)
        {
            health = isHeal ? health + amount : health - amount;
        }
    }
}