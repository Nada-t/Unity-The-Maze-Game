using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectablesSystem : MonoBehaviour
{
    public int healthNum = 3;
    public int StopTraps = 5;
    public int Bombs = 7;
    public int birdView = 2;
    public int lowerWalls = 8;
    public int checkPoint = 10;
    public GameObject lifeObject;

    damageCalculate DC;
    collectablesPanelController CPC;
    Weaponspanel wp;
    private void Start()
    {
        DC = GameObject.FindGameObjectWithTag("Player").GetComponent<damageCalculate>();
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();
    }
    private void Update()
    {
       
       // lifeObject.transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);

        // to use the hearts 
        if(Input.GetKeyDown(KeyCode.H) && wp.LifesNum > 0 && DC.health < 100)
        {
            Debug.Log(wp.LifesNum + "@@@@@@@@@@@@@@@@@@@@");
            DC.health += 25;
            //decrease the hearts number in the panal 
            wp.LifesNum--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Life")
        {
            DC.health += 100;
            lifeObject.GetComponent<AudioSource>().Play();

            Destroy(lifeObject, 0.5f);

        }
    }
}
