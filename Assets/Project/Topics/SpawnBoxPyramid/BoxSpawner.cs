using System;
using System.Collections;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private int maxDepth;
    [SerializeField] GameObject box;
    [SerializeField] float spawnTime;

    private float boxWidth = 1.0f;
    private float boxHeight = 1.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StartCoroutine(SpawnBoxes());
        }
    }

    IEnumerator SpawnBoxes()
    {
        for (int i = 0; i < maxDepth; i++)
        {
            float half = i * (boxWidth * 0.5f);
            float xStart = -half;

            for (int j = 0; j < i + 1; j++)
            {
                float x = xStart + boxWidth * j;
                float y = boxHeight * i;
                SpawnBox(x, y);
                yield return new WaitForSeconds(spawnTime);
            }
        }
    }

    private void SpawnBox(float x, float y)
    {
        var tempBox = UnityEngine.Object.Instantiate(box, new Vector3(x, -y, 0), new Quaternion(0, 0, 0, 0));
        tempBox.GetComponent<Renderer>().material.color = GetColor(UnityEngine.Random.Range(1, 6));
    }

    private Color GetColor(int color)
    {
        switch (color)
        {
            case 1:
                return Color.black;
            case 2:
                return Color.blue;
            case 3:
                return Color.green;
            case 4:
                return Color.red;
            case 5:
                return Color.yellow;
            default:
                return Color.white;
        }

    }
}
