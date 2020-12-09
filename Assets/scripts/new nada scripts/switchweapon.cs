using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchweapon : MonoBehaviour
{
    public GameObject ax;
    public GameObject[] weapons;
    public int wnum = 0;
    int temp = 0;
    void Update()
    {
        if (wnum == 0)
        {
            ax.SetActive(true);
        }

        if (wnum != 0) ax.SetActive(false);       
        if (temp != 0 &&  wnum != temp) weapons[temp - 1].SetActive(false);
        
        if (wnum == 1)
        {
            weapons[0].SetActive(true);
        }
        else if (wnum == 2)
        {
            weapons[1].SetActive(true);
        }
        else if (wnum == 3)
        {
            weapons[2].SetActive(true);
        }
        else if (wnum == 4)
        {
            weapons[3].SetActive(true);
        }
        else if (wnum == 5)
        {
            weapons[4].SetActive(true);
        }
        temp = wnum;
    }
}
