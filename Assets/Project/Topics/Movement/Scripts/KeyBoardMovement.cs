using System;
using UnityEngine;

internal class KeyBoardMovement : MonoBehaviour, IMovement
{
    public Vector3 GetNextPosition(Vector3 position, Rect area, int speed)
    {
        var directionVector = GetDirection();
        var nextPosition = transform.position + directionVector * (speed * Time.deltaTime) ;
        
        // Remember to define floating point
        Debug.Log((directionVector * (speed * Time.deltaTime)).ToString("F5"));

        if (IsOutOfBound(nextPosition, area)) return position;
        return nextPosition;
    }

    private static bool IsOutOfBound(Vector3 nextPosition, Rect area)
    {
        return nextPosition.x < area.xMin || nextPosition.x > area.xMax
            || nextPosition.y < area.yMin || nextPosition.y > area.yMax;
    }

    private static Vector3 GetDirection()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.down;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        return direction;
    }
}