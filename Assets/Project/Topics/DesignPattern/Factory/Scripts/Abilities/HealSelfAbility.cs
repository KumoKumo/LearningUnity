using UnityEngine;

namespace ReflectionFactory
{
    public class HealSelfAbility : Ability
    {
        public override string Name => "heal";

        public override void Process()
        {
            SimplePlayer player = GameObject.FindObjectOfType<SimplePlayer>() as SimplePlayer;
            player.ChangeHealth(10, true);
            Debug.Log("Healing 10 HP ! The Player's HP is now " + player.Health);
        }
    }
}


