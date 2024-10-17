using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipsController : MonoBehaviour
{
    Animator anim;
    [SerializeField] private float speed;
    private float horizonal;


    [Header("Clamp")]
    [SerializeField] float minX;
    [SerializeField] float maxX;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        horizonal = Input.GetAxis("Horizontal") * Time.deltaTime;
       
        
        if (horizonal > 0)
        {
            transform.position += Vector3.right * speed;
        }
        else if(horizonal < 0)
        {
            transform.position -= Vector3.left * -speed;
        }

     
        // Mathf.Clamp
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
        
    }

 
       

}
       


   

