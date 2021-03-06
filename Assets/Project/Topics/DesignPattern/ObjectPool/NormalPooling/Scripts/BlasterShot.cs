﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterShot : MonoBehaviour
{
    public float moveSpeed = 30f;

    private float lifeTime;
    private float maxLifeTime = 4f;

    private void OnEnable()
    {
        lifeTime = 0f;
    }

    private void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifeTime)
        {
            BlasterShotPool.Instance.ReturnToPool(this);
        }
    }
}
