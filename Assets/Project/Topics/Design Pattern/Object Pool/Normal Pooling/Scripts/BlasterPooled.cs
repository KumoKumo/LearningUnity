using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterPooled : MonoBehaviour
{
    [SerializeField]
    private BlasterShot blasterShotPrefab;

    [SerializeField]
    private float refireRate = 2f;

    private float fireTimer = 0;

    private void Update()
    {
        fireTimer += Time.deltaTime;
        if (fireTimer >= refireRate)
        {
            fireTimer = 0;
            Fire();
        }
    }

    private void Fire()
    {
        var shot = BlasterShotPool.Instance.Get();
        shot.transform.position = transform.position;
        shot.gameObject.SetActive(true);
    }
}
