using System.Collections;
using System.Collections.Generic;
using ReflectionFactory;
using UnityEngine;

/// <summary>
/// This is a bad demo on how to really use the Factory
/// </summary>

public class FactoryDemo : MonoBehaviour
{
    private Ability ability01;
    private Ability ability02;

    private void Start()
    {
        ability01 = AbilityFactory.GetAbility("fire");
        ability02 = AbilityFactory.GetAbility("heal");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ability01.Process();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ability02.Process();
        }

            
    }
}