using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverPanal : MonoBehaviour
{
    public damageCalculate damageCalc;
    musicController mc;

    // Start is called before the first frame update
    void Start()
    {
        damageCalc = GameObject.FindGameObjectWithTag("Player").GetComponent<damageCalculate>();
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Stop();
        mc = GameObject.FindGameObjectWithTag("Music").GetComponent<musicController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            damageCalc.isDead = false;
            mc.isSecond = true;
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();

            SceneManager.LoadScene(1);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
