using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingCam : MonoBehaviour
{
    public Transform player;
    public float hight;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + new Vector3(0, hight, 0);
        offset = this.transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = player.transform.position + offset;
    }
}
