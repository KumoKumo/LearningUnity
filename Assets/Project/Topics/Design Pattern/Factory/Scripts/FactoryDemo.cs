using System.Collections;
using System.Collections.Generic;
using ReflectionFactory;
using UnityEngine;

public class FactoryDemo : MonoBehaviour
{
    private Ability ability;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //ability = AbilityFactory.GetAbility("fire");
            //AbilityFactoyUsingGeneric.GetAbility<StartFireAbility>().Process();
            FastActivatorOfAbilityFactoryUsingGeneric<StartFireAbility>.Create().Process();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //ability = AbilityFactory.GetAbility("heal");
            //AbilityFactoyUsingGeneric.GetAbility<HealSelfAbility>().Process();
            FastActivatorOfAbilityFactoryUsingGeneric<HealSelfAbility>.Create().Process();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ability.Process();
        }
            
    }
}