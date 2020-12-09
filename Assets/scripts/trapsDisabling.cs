using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapsDisabling : MonoBehaviour
{
   public  GameObject[] animators;
    collectablesPanelController CPC;
    Weaponspanel wp;
    private void Start()
    {
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I) && wp.StopTraps > 0)
        {
            // Debug.Log("bb");
           // Debug.Log("///////////////////////////" + wp.StopTraps);
            foreach (GameObject i in animators)
            {
                i.GetComponent<Animator>().SetBool("disabled", true);
            }
            wp.StopTraps--; 
        }
    }

    private void LateUpdate()
    {
        foreach (GameObject i in animators)
        {
            i.GetComponent<Animator>().SetBool("disabled", false);
        }
    }
}
