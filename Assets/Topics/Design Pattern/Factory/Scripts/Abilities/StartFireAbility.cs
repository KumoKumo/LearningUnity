using UnityEngine;

namespace ReflectionFactory
{
    public class StartFireAbility : Ability
    {

        //Expression-bodied members
        public override string Name => "fire";

        public override void Process()
        {
            GameObject.FindObjectOfType<SimplePlayer>().StartFire();
        }
    }
}


