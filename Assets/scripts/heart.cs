using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
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
            //increase the hearts number on the system and panal 
            CPC.P_LifesNum++;

            //destroy the heart

            Destroy(gameObject);
        }
    }
}
