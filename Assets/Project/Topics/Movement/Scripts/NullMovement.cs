using UnityEngine;

// Null Object pattern
internal class NullMovement : IMovement
{
    public Vector3 GetNextPosition(Vector3 position, Rect area, int speed)
    {
        return Vector3.zero;
    }
}