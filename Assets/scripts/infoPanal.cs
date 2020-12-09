using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanal : MonoBehaviour
{
    Animator anim;
    bool show = false;
    bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)&& show==false)
        {
            anim.SetBool("showing", true);
            show = true;
        }
        else if(Input.GetKeyDown(KeyCode.M)&& show == true)
        {
            anim.SetBool("showing", false);
            show = false;
        }

        if(Input.GetKeyDown(KeyCode.Space)&& isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
