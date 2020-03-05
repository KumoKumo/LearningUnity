using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    [SerializeField]
    private BlasterShotNoPool blasterShotPrefab;

    [SerializeField]
    private float refireRate = 2f;

    private float fireTimer = 0;

    private void Update()
    {
        fireTimer += Time.deltaTime;
        if(fireTimer >= refireRate)
        {
            fireTimer = 0;
            Fire();
        }
    }

    private void Fire()
    {
        var shot = Instantiate(blasterShotPrefab, transform.position, blasterShotPrefab.transform.rotation);
    }
}
