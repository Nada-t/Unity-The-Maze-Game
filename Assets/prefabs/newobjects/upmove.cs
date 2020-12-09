using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upmove : MonoBehaviour
{
    float x ;
    public int obj;

    
    void Start()
    {
        if (obj == 5 || obj == 4 || obj == 3) x = transform.position.y;

        else if( obj == 2) x = transform.position.y;

        else x = transform.position.y;
    }

    
    void Update()
    {
        if (obj == 5 || obj == 4 || obj == 3) 
        {
            if (transform.position.y - x < 1f)
            {
                transform.Translate(new Vector3(0, Time.deltaTime, 0)) ;
            }
        }
        else if(obj == 2 )
        {
            if (transform.position.y - x < 1f)
            {
                transform.Translate(new Vector3(0, 0, -Time.deltaTime));
            }
        }
        else
        {
            if (transform.position.y - x < 1f)
            {
                transform.Translate(new Vector3(0, 0, Time.deltaTime));
            }
        }

        if( obj == 3 ) transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        else if (obj == 4) transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        else if (obj == 5) transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
        else transform.Rotate(new Vector3(0, 0, 100) * Time.deltaTime);
    }
}
