using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBackground : MonoBehaviour
{
    public GameObject newBackground;
    public Transform backgroundPosition;
    public Transform player;
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        
        if (distance >= 70f)
            Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NewImage")
        {
            Debug.Log("01010");
            Instantiate(newBackground, backgroundPosition.position, Quaternion.identity);
            // background.transform.SetParent(canvas.transform,false);

        }
    }
}
           

