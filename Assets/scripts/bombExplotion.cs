using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombExplotion : MonoBehaviour
    
{

    public float delay = 1.5f;
    float countDown;
    public GameObject explotionEffect;
    public damageCalculate damageCalc;
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        countDown = delay;
        damageCalc = GameObject.FindGameObjectWithTag("Player").GetComponent<damageCalculate>();
        AS = gameObject.GetComponent<AudioSource>();
        AS.Play();
        StartCoroutine("healthDecrease");
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
           explode();
            damageCalc.healthBarManager();
        }
    }

  
    void explode()
    {
        GameObject ins= Instantiate(explotionEffect, transform.position, transform.rotation);

        Destroy(ins, 2f);
        Destroy(this.gameObject,0.5f);

    }

    IEnumerator healthDecrease()
    {
        yield return new WaitForSeconds(1.3f);
        damageCalc.health -= 15;

    }
}
