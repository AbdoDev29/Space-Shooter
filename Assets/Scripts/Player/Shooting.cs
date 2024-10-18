using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform[] bulletPosition;
    [SerializeField] float speedBullet;
    [SerializeField] float nextBulletTime;
    SpaceshipsController spaceshipsController;

    private void Awake()
    {
        spaceshipsController = FindObjectOfType<SpaceshipsController>();
    }

    private void Start()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        StartCoroutine(NextBollet());
    }
    IEnumerator NextBollet()
    {
        while (spaceshipsController != null)
        {
           
            if (Input.GetMouseButton(0))
            {
                GameObject righrBullet = Instantiate(bullet, bulletPosition[0].position, Quaternion.identity);
                GameObject leftBullet = Instantiate(bullet, bulletPosition[1].position, Quaternion.identity);
                GameObject middleBullet = Instantiate(bullet, bulletPosition[2].position, Quaternion.identity);
                //StartCoroutine(MoveBullet(righrBullet,leftBullet));
                yield return  (new WaitForSeconds(nextBulletTime));
              
            }
            yield return null;
        }
    }

    IEnumerator MoveBullet(GameObject rightBullet ,GameObject leftBullet)
    {
        while (rightBullet != null && leftBullet != null)
        {
            rightBullet.transform.position += Vector3.up * speedBullet * Time.deltaTime;
            leftBullet.transform.position += Vector3.up * speedBullet * Time.deltaTime;
            yield return null;
        }
    }
  
}
