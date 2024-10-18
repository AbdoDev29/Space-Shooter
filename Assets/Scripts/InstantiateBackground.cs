using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBackground : MonoBehaviour
{
    SpaceshipsController spaceshipsController;
    public GameObject newBackground;
    public Transform backgroundPosition;
    public Transform player;

    private void Awake()
    {
        spaceshipsController = FindObjectOfType<SpaceshipsController>();
    }
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        
        if (distance >= 70f)
            Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!spaceshipsController.isPlayerDead)
        {
            if (collision.gameObject.tag == "NewImage")
            {
            
                Instantiate(newBackground, backgroundPosition.position, Quaternion.identity);
            }

        }
    }
}
           
           


