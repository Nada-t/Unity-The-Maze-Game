using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject player;

    Weaponspanel wp;

    // Start is called before the first frame update
    void Start()
    {
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();

        player = this.transform.parent.gameObject;   
    }

    // Update is called once per frame
    void Update()
    {
        if (wp.cursorlock == false)
        {
            var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
            smoothV.x = Mathf.Lerp(smoothV.x, mouseDelta.x, 1f / smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, mouseDelta.y, 1f / smoothing);

            mouseLook += smoothV;
            mouseLook.y = Mathf.Clamp(mouseLook.y, -90, 90);
            //rotating the camera around X axis
            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
            // rotate the character around y axis
            player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
        }
        
    }
}
