using System;
using UnityEngine;
namespace ReflectionFactory
{
    internal class SimplePlayer : MonoBehaviour
    {
        [SerializeField] private float health = 100;

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