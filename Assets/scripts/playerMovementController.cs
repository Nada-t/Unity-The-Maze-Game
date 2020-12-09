using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementController : MonoBehaviour
{

    public float speed;
    RaycastHit mousehit;
    bool beginning = true;
    Vector3 position1 = new Vector3(187f, 6f, -95f);
    Vector3 position2 = new Vector3(2f, 6f, -95f);
    public damageCalculate damageCalc;
    public GameObject collectSound;
    public win winning;
    // Start is called before the first frame update
    void Start()
    {
        damageCalc = gameObject.GetComponent<damageCalculate>();
        winning = GameObject.FindGameObjectWithTag("win").GetComponent<win>();

        if (Random.Range(0, 2) == 0)
        {
            transform.position = position1;
            beginning = false;
        }
        else
        {
            transform.position = position2;
            beginning = false;
        }
        // it hides and locks the curser during the game mode
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!beginning && damageCalc.isDead==false && winning.isWinning==false)
        {
            float forwardAbackward = Input.GetAxis("Vertical") * speed;
            float forward = Input.GetAxis("Horizontal") * speed;

            Vector3 movement = new Vector3(forward, 0, forwardAbackward) * Time.deltaTime;
            transform.Translate(movement);

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "collectable")
        {
            collectSound.gameObject.GetComponent<AudioSource>().Play();
        }
    }


}
