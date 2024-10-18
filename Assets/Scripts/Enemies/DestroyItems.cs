using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyItems : MonoBehaviour
{
   
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item" || other.gameObject.tag == "Bullet")
            Destroy(other.gameObject);
    }
}
