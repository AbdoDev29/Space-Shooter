using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBackground : MonoBehaviour
{
    public GameObject newBackground;
    public Transform backgroundPosition;
   

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NewImage")
        {
            Debug.Log("01010");
            GameObject background = Instantiate(newBackground, backgroundPosition.position, Quaternion.identity);
        }
    }
}
