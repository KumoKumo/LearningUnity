using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField][Range(1,6)] private int digits = 1;
    [SerializeField]private Vector3 velocity;

    public Vector3 Velocity
    {
        get => velocity;
        set => velocity = value;
    }

    public float Mass { get; private set; } = 100f;

    private void Start()
    {
        SetUpMass();
        SetUpMovement();
    }

    private void SetUpMovement()
    {
        if(gameObject.name == "BigCube")
        {
            velocity = new Vector3(-speed, 0, 0);
        }
        else
        {
            velocity = Vector3.zero;
        }
    }

    private void SetUpMass()
    {
        Mass = Mathf.Pow(Mass, (float)digits - 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log($"{gameObject.name}'s mass is {Mass}");
        }
    }

}
