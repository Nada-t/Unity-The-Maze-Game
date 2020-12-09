using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    collectablesPanelController CPC;

    // Start is called before the first frame update
    void Start()
    {
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // increase the number of birdEye in the panal 
            CPC.P_birdView++;
   
            //destroy the gameobject
            Destroy(gameObject);
        }
    }
}
