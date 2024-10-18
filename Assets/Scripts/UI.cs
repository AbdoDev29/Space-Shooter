using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{

    SpaceshipsController spaceshipsController;
    public GameObject losePanal;
    private void Awake()
    {
        spaceshipsController = FindObjectOfType<SpaceshipsController>();
        losePanal.SetActive(false);
    }
    public void Update()
    {
        Lose();
    }

    public void Lose()
    {
        if (spaceshipsController.isPlayerDead)
            losePanal.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
