using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingWall : MonoBehaviour
{
    Animator anim;
    collectablesPanelController CPC;
    Weaponspanel wp;
    void Start()
    {
        anim = GetComponent<Animator>();
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && Input.GetKey(KeyCode.Z) && wp.lowerWalls > 0)
        {
            anim.SetBool("isplayer", true);
            wp.lowerWalls--;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.SetBool("isplayer", false);
        }
    }
}
