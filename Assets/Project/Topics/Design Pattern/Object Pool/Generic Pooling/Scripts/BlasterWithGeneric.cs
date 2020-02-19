using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterWithGeneric : MonoBehaviour
{
    [SerializeField] 
    private float fireRate = 1.4f;

    private float fireTimer = 0f;

    private void Update()
    {
        fireTimer += Time.deltaTime;
        if(fireTimer >= fireRate)
        {
            fireTimer = 0;
            Fire();
        }
    }

    private void Fire()
    {
        var shot = ShotPool.Instance.Get();
        shot.transform.position = transform.position;
        shot.gameObject.SetActive(true);
    }
}
