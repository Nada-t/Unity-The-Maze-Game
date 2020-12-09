using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicController : MonoBehaviour
{
    AudioSource AS;
     public Slider volumeControl;
     float step;
   public bool isSecond = false;

    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        AS = GetComponent<AudioSource>();
        step = volumeControl.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSecond==false)
            AS.volume = volumeControl.value;
        else
            AS.volume = step;
    }
}
