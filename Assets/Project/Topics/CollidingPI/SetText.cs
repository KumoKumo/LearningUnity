using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetText : MonoBehaviour
{
    private CollisionManager collisionManager;
    private Cube cube;
    private TextMesh textMesh;

    private void Awake()
    {
        textMesh = gameObject.GetComponent<TextMesh>();
    }

    void Start()
    {
        collisionManager = GameObject.Find("SmallCube").GetComponent<CollisionManager>();
        cube = GameObject.Find("BigCube").GetComponent<Cube>();
    }

    void Update()
    {
        int count = collisionManager.Count;
        int floatingPoint = cube.Digits - 1;
        float result = count / (Mathf.Pow(10, (float)floatingPoint));
        textMesh.text = $"PI: {result}";
    }
}
