using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    bool isDistroied = false;
    public GameObject explosionPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Bullet")
            isDistroied = true;

    }
    private void Update()
    {
        if (isDistroied)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            isDistroied = false;

        }
    }

}
