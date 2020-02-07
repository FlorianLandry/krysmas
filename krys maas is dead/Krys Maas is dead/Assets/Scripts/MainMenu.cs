using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject secondMenu;

    public void Start()
    {
        mainMenu.SetActive(true);
        secondMenu.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Exit()
    {
        Debug.Log("xoxo");
        Application.Quit();
    }

    public void How2Play()
    {
        mainMenu.SetActive(false);
        secondMenu.SetActive(true);
    }

    public void Back()
    {
        secondMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
