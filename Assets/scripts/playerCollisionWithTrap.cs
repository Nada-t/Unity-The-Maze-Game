using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisionWithTrap : MonoBehaviour
{
    public damageCalculate damageCalc;
    public float waitingTime ;
    public float damageTaken = 30;
    float temp;
    // Start is called before the first frame update
    void Start()
    {
        damageCalc = transform.GetComponent<damageCalculate>();
        temp = waitingTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trap")
        {
            damageCalc.health -= damageTaken;
            damageCalc.healthBarManager();
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "trap")
        {
            waitingTime -= Time.deltaTime;
            if (waitingTime <= 0)
            {
                damageCalc.health -= damageTaken;
                damageCalc.healthBarManager();
                waitingTime = temp;
            }
        }
    }

   
}
