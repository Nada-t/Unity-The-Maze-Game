using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxDestruction : MonoBehaviour
{
    public GameObject crackedBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ax")
        {
           GameObject inst= Instantiate(crackedBox, transform.position,transform.rotation);
            Debug.Log("hit");
            Destroy(inst, 2f);
            Destroy(gameObject);
        }
    }
}
