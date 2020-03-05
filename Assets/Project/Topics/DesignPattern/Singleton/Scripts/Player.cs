using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _character;
    [SerializeField] private Transform _target;
    internal void SayHi()
    {
        Debug.Log("Hi! I'm at " + this.gameObject.transform.position);
    }

}
