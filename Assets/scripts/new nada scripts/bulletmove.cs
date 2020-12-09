using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{

    public Rigidbody bullet;
    public float speed = 100f;
    public Transform pos;
    public ParticleSystem muzzle;
    Weaponspanel wp;

    void Start()
    {
        muzzle.gameObject.SetActive(false);
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();
    }

    void Update()
    {
        if (wp.isup == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody instbullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                Rigidbody instbulletrigid = instbullet.GetComponent<Rigidbody>();
                instbulletrigid.AddForce(pos.right * -speed);
                partcl();
            }
        }
    }

    void partcl()
    {

        muzzle.gameObject.SetActive(true);
        muzzle.Play();
    }
    //private void OnCollisionEnter(Collision other)
    //{
    //    Debug.Log("***************************");
    //    Destroy(bullet.gameObject);
    //    Destroy(this.gameObject);
    //}
}
