using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Coins_rotate : MonoBehaviour
{
    collectablesPanelController CPC;
    void Start()
    {
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            CPC.coinscount++;
            Destroy(gameObject);
        }
    }  
    void Update()
    {
        transform.Rotate(0, 5, 0, Space.World);
        
    }
}
