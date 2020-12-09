using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public GameObject mainMen;
    public GameObject optionsMenu;
    AudioSource clicking;

    private void Start()
    {
        clicking = GetComponent<AudioSource>();
    }

    public void playGame()
    {
        clicking.Play();
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        clicking.Play();
        Debug.Log("quit");
        Application.Quit();
    }

    public void hideOptions()
    {
        clicking.Play();
        optionsMenu.SetActive(false);
        mainMen.SetActive(true);
    }

    public void hideMain()
    {
        clicking.Play();
        mainMen.SetActive(false);
        optionsMenu.SetActive(true);
    }
}
