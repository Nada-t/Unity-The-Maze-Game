using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class cameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    collectablesPanelController CPC;
    public float switichingTime;
   public float temp;  // to control the total time of switiching
    int audioControl = 1;    // to play the audio once only
    public Text timingText;
    Weaponspanel wp;

    // Start is called before the first frame update
    void Start()
    {
        cameras[1].GetComponent<Camera>().enabled = false;
        cameras[1].GetComponent<AudioListener>().enabled = false;
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
        temp = switichingTime;
        timingText.text = "BirdEye Timer : " + Mathf.Abs(temp).ToString("F1");
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.C) && wp.birdView > 0)
        {
           // Debug.Log("***********************" + wp.birdView);
            if (audioControl > 0)
            {
                gameObject.GetComponent<AudioSource>().Play();
                audioControl--;
            }
            //temp = switichingTime;
            if (temp >= 0)
            {
               
                cameras[0].GetComponent<Camera>().enabled = false;
                cameras[0].GetComponent<AudioListener>().enabled = false;
                cameras[1].GetComponent<Camera>().enabled = true;
                cameras[1].GetComponent<AudioListener>().enabled = true;
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                temp -= 1 * Time.deltaTime;
                timingText.text = "BirdEye Timer : " +Mathf.Abs(temp).ToString("F1");
            }
            else
            {
              
                temp = switichingTime;
                wp.birdView--;
                audioControl++;
            }

        }
        else
        {
            cameras[0].GetComponent<Camera>().enabled = true;
            cameras[0].GetComponent<AudioListener>().enabled = true;
            cameras[1].GetComponent<Camera>().enabled = false;
            cameras[1].GetComponent<AudioListener>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
           

        }
    }

   
}
