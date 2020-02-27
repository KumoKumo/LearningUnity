using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField] private int count;
    private Cube otherCube;
    private Cube thisCube;
    private GameObject wall;
    private float timeSteps = 5000;

    public int Count => count;

    private void Awake()
    {
        thisCube = gameObject.GetComponent<Cube>();
        count = 0;
    }

    private void Start()
    {
        wall = GameObject.FindGameObjectWithTag("Wall");
        otherCube = GameObject.Find("BigCube").GetComponent<Cube>();
    }

    private void FixedUpdate()
    {
        MoveTheCubes();
        
    }

    private void MoveTheCubes()
    {
        for(int i = 0; i< timeSteps; i++)
        {
            if (IsCollidedWithObject)
            {
                CollideWithOtherCube();
            }
            else if (IsCollidedWithWall)
            {
                CollideWithWall();
            }
            transform.position += thisCube.Velocity * Time.fixedDeltaTime / timeSteps;
            otherCube.transform.position += otherCube.Velocity * Time.fixedDeltaTime / timeSteps;
        }
    }

    private bool IsCollidedWithWall => 
        ((transform.position.x - transform.localScale.x/2) <= (wall.transform.position.x + wall.transform.localScale.x/2));

    private bool IsCollidedWithObject => 
        ((otherCube.transform.position.x - otherCube.transform.localScale.x / 2) <= (transform.position.x + transform.localScale.x / 2));

    private void CollideWithWall()
    {
        thisCube.Velocity = -1 * thisCube.Velocity;
        count++;
    }

    private void CollideWithOtherCube()
    {
        Vector3[] newVelocities = VelocityAfterCollision(thisCube.Velocity, otherCube.Velocity, thisCube.Mass, otherCube.Mass);
        thisCube.Velocity = newVelocities[0];
        otherCube.Velocity = newVelocities[1];
        count++;
    }

    // Equation for One-dimensional Newtonian Elastic Collision
    // https://en.wikipedia.org/wiki/Elastic_collision
    private Vector3[] VelocityAfterCollision(Vector3 u1, Vector3 u2, float m1, float m2)
    {
        Vector3 v1 = new Vector3();
        Vector3 v2 = new Vector3();

        v1 = (m1 - m2) / (m1 + m2) * u1 + (2 * m2) / (m1 + m2) * u2;
        v2 = (2 * m1) / (m1 + m2) * u1 + (m2 - m1) / (m1 + m2) * u2;

        return new Vector3[2] {v1,v2};
    }
}
