using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axControl : MonoBehaviour
{
    public Animator axAnimatior;
    public GameObject ax;
    public damageCalculate damageCalc;
    Weaponspanel wp;


    // Start is called before the first frame update
    void Start()
    {
       
        wp= GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>(); 
        damageCalc = gameObject.GetComponent<damageCalculate>();
        axAnimatior = GameObject.FindGameObjectWithTag("Ax").GetComponent<Animator>();
        ax.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (wp.cursorlock == false )
        {
            axAnimatior.SetBool("attack", false);
            if (Input.GetMouseButtonDown(0) && damageCalc.isDead == false)
            {
                ax.GetComponent<AudioSource>().Play();
                axAnimatior.SetBool("attack", true);
                StartCoroutine("showAx");
            }

        } 
    }


    IEnumerator showAx()
    {
        ax.gameObject.GetComponent<MeshRenderer>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        ax.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
