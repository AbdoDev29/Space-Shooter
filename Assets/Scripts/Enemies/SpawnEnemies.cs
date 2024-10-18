using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] item;
    public Transform[] positionItem;
    SpaceshipsController spaceshipsController;
    GameManager gameManager;
    [SerializeField] float itemSpeed;
   
    private void Awake()
    {
        spaceshipsController = FindObjectOfType<SpaceshipsController>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        StartCoroutine(CreatNewItem());
    }

    private void Update()
    {


        
    }

    IEnumerator CreatNewItem()
    {
        
            while (spaceshipsController != null)
            {
                if(item.Length > 0 && positionItem.Length > 0)
                {
                    GameObject bomb = Instantiate(item[Random.Range(0, item.Length)],
                     positionItem[Random.Range(0, positionItem.Length)].position, Quaternion.Euler(80f,0f,0f));
                    StartCoroutine(MoveItem(bomb));
                    yield return (new WaitForSeconds(0.5f));

                }
            }

        
    }

    IEnumerator MoveItem(GameObject bomb)
    {
        while (bomb != null)
        {
            bomb.transform.position += Vector3.down * itemSpeed * Time.deltaTime;
            yield return null;
        }
    }
}
