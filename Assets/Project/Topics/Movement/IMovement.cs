using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement 
{
    Vector3 GetNextPosition(Vector3 position, Rect area, int speed);
}
