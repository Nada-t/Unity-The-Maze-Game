using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBox : MonoBehaviour
{
    public GameObject[] obj;
    public  int randindx = 0;
    bool available = true;

    GameObject inst;

    collectablesSystem CS;  // will minus whenever created to control the number

    public GameObject coin;
    void Start()
    {
        CS = GameObject.FindGameObjectWithTag("Player").GetComponent<collectablesSystem>();

        while (available)
        {

            inst = Instantiate(coin, transform.position, transform.rotation);
            inst.transform.Translate(new Vector3(0, 1, 0));
            available = false;
        }      
    }
}
