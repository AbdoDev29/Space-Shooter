using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;
    private void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            // partical
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
