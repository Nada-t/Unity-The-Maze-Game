using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject youwinmodel;
    public GameObject winPanlel;
    public bool isWinning = false;
   
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            youwinmodel.SetActive(true);
            winPanlel.gameObject.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
            isWinning = true;
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Stop();

        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && isWinning==true)
        {
            isWinning = false;
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();

            SceneManager.LoadScene(1);
        }

        if (Input.GetKey(KeyCode.Escape)&& isWinning==true)
        {
            Application.Quit();
        }
    }
}