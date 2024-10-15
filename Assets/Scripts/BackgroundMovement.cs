using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
