using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterShotPool : MonoBehaviour
{
    [SerializeField]
    private BlasterShot blasterShotPrefab;

    private Queue<BlasterShot> blasterShots = new Queue<BlasterShot>();
    public static BlasterShotPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public BlasterShot Get()
    {
        if(blasterShots.Count == 0)
        {
            AddShots(1);
        }

        return blasterShots.Dequeue();
    }

    private void AddShots(int count)
    {
        for(int i= 0; i < count; i++)
        {
            BlasterShot blasterShot = Instantiate(blasterShotPrefab);
            blasterShot.gameObject.SetActive(false);
            blasterShots.Enqueue(blasterShot);
        }
    }

    public void ReturnToPool(BlasterShot blasterShot)
    {
        blasterShot.gameObject.SetActive(false);
        blasterShots.Enqueue(blasterShot);
    }
}
