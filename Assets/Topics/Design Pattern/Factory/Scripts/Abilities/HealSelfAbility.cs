using UnityEngine;

namespace ReflectionFactory
{
    public class HealSelfAbility : Ability
    {
        public override string Name => "heal";

        public override void Process()
        {
            GameObject.FindObjectOfType<SimplePlayer>().ChangeHealth(10, true);
            Debug.Log("Healing 10 HP !");
        }
    }
}


