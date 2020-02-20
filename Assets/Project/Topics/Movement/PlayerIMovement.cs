using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIMovement : MonoBehaviour
{
    [SerializeField] [Range(1,5)] private int speed = 1;
    [SerializeField] private Rect area;

    private IMovement _movement;

    private void Awake()
    {
        _movement = gameObject.GetComponent<IMovement>();
        if(_movement == null)
        {
            Debug.Log("Can't detect required component");
            _movement = new NullMovement();
        }
    }

    private void Update()
    {
        transform.position = _movement.GetNextPosition(transform.position, area, speed);
    }

}
