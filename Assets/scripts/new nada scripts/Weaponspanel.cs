using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weaponspanel : MonoBehaviour
{
    collectablesPanelController CPC;

    public GameObject axbutton;

    public Sprite openlock;
    public Sprite closelock;

    public GameObject[] closedbtn;
    public Button[] pricelocks;
    public Button[] openweapons;

    public GameObject[] closedbtn1;
    public Button[] pricelocks1;
    public Button[] openweapons1;

    public GameObject descpanel;
    Animator panalAnimatior;
    public bool isup = false;
    public bool cursorlock = false;

    switchweapon sw;

    public Button weaponbtn;
    public Button marketbtn;
    
    public int LifesNum = 0;
    public int StopTraps = 0;
    public int checkPoint = 0;
    public int birdView = 0;
    public int lowerWalls = 0;

    int[] openedwepon;
    bool anypan = true;

    public GameObject marketpan;
    void Start()
    {
        openedwepon = new int[5];
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
        panalAnimatior = gameObject.GetComponent<Animator>();

        sw = GameObject.FindGameObjectWithTag("weapon").GetComponent<switchweapon>();

        Button axbtn = axbutton.GetComponent<Button>();
        axbtn.onClick.AddListener(TaskOnClick6);

        Button closbtn1 = closedbtn[0].GetComponent<Button>();
        closbtn1.onClick.AddListener(TaskOnClick1);
        Button closbtn2 = closedbtn[1].GetComponent<Button>();
        closbtn2.onClick.AddListener(TaskOnClick2);
        Button closbtn3 = closedbtn[2].GetComponent<Button>();
        closbtn3.onClick.AddListener(TaskOnClick3);
        Button closbtn4 = closedbtn[3].GetComponent<Button>();
        closbtn4.onClick.AddListener(TaskOnClick4);
        Button closbtn5 = closedbtn[4].GetComponent<Button>();
        closbtn5.onClick.AddListener(TaskOnClick5);

        Button btn1 = openweapons[0].GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick11);
        Button btn2 = openweapons[1].GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick22);
        Button btn3 = openweapons[2].GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick33);
        Button btn4 = openweapons[3].GetComponent<Button>();
        btn4.onClick.AddListener(TaskOnClick44);
        Button btn5 = openweapons[4].GetComponent<Button>();
        btn5.onClick.AddListener(TaskOnClick55);

        /////////////////////////////////for market buttons////////////////////////////////////////////

        Button closbtn1m = closedbtn1[0].GetComponent<Button>();
        closbtn1m.onClick.AddListener(TaskOnClick1m);
        Button closbtn2m = closedbtn1[1].GetComponent<Button>();
        closbtn2m.onClick.AddListener(TaskOnClick2m);
        Button closbtn3m = closedbtn1[2].GetComponent<Button>();
        closbtn3m.onClick.AddListener(TaskOnClick3m);
        Button closbtn4m = closedbtn1[3].GetComponent<Button>();
        closbtn4m.onClick.AddListener(TaskOnClick4m);
        Button closbtn5m = closedbtn1[4].GetComponent<Button>();
        closbtn5m.onClick.AddListener(TaskOnClick5m);

        Button btn1m = openweapons1[0].GetComponent<Button>();
        btn1m.onClick.AddListener(TaskOnClick11m);
        Button btn2m = openweapons1[1].GetComponent<Button>();
        btn2m.onClick.AddListener(TaskOnClick22m);
        Button btn3m = openweapons1[2].GetComponent<Button>();
        btn3m.onClick.AddListener(TaskOnClick33m);
        Button btn4m = openweapons1[3].GetComponent<Button>();
        btn4m.onClick.AddListener(TaskOnClick44m);
        Button btn5m = openweapons1[4].GetComponent<Button>();
        btn5m.onClick.AddListener(TaskOnClick55m);

        ////////////////////////////////for weapon& market button//////////////////////////////////////////

        Button wbtn = weaponbtn.GetComponent<Button>();
        wbtn.onClick.AddListener(TaskOnClick1w);
        Button mbtn = marketbtn.GetComponent<Button>();
        mbtn.onClick.AddListener(TaskOnClick2w);
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.X) && !isup)
        {
            panalAnimatior.SetBool("isup", true);
            Cursor.lockState = CursorLockMode.None;
            isup = true;
            cursorlock = true;

            if(anypan == false)
            {
                for (int i = 0; i < closedbtn1.Length; i++)
                {
                    closedbtn1[i].SetActive(true);
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.X) && isup)
        {
            panalAnimatior.SetBool("isup", false);
            Cursor.lockState = CursorLockMode.Locked ;
            isup = false;
            cursorlock = false;
        }
    }

    void TaskOnClick6()
    {
        if (isup) sw.wnum = 0;
    }

    void TaskOnClick1w()
    {
        if (isup)
        {
            anypan = true;
            for (int i=0;i<closedbtn1.Length;i++)
            {
                closedbtn1[i].SetActive(false);
            }
            for (int i = 0; i < openweapons1.Length; i++)
            {
                openweapons1[i].gameObject.SetActive(false);
            }

            axbutton.SetActive(true);
            for (int i = 0; i < closedbtn.Length; i++)
            {
                if (openedwepon[i] == 0) closedbtn[i].SetActive(true);
            }
            for (int i = 0; i < openweapons.Length; i++)
            {
                openweapons[i].gameObject.SetActive(true);
            }
        }
    }

    void TaskOnClick2w()
    {
        if (isup)
        {
            anypan = false;
            marketpan.SetActive (true);
            for (int i = 0; i < closedbtn1.Length; i++)
            {
                closedbtn1[i].SetActive(true);
            }
            for (int i = 0; i < openweapons1.Length; i++)
            {
                openweapons1[i].gameObject.SetActive(true);
            }
            axbutton.SetActive(false);
            for (int i = 0; i < closedbtn.Length; i++)
            {
                closedbtn[i].SetActive(false);
            }
            for (int i = 0; i < openweapons.Length; i++)
            {
                openweapons[i].gameObject.SetActive(false);
            }
        }
    }


    void TaskOnClick1()
    {
        if (isup)
        {
            if (CPC.coinscount >= 5)
            {
                CPC.coinscount -= 5;
                closedbtn[0].SetActive(false);
                openedwepon[0] = 1;
                pricelocks[0].image.sprite = openlock;
                sw.wnum = 1;
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick2()
    {
        if (isup)
        {
            if (CPC.coinscount >= 15)
            {
                CPC.coinscount -= 15;
                closedbtn[1].SetActive(false);
                openedwepon[1] = 1;
                pricelocks[1].image.sprite = openlock;
                sw.wnum = 2;
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick3()
    {
        if (isup)
        {
            if (CPC.coinscount >= 20)
            {
                CPC.coinscount -= 20;
                closedbtn[2].SetActive(false);
                openedwepon[2] = 1;
                pricelocks[2].image.sprite = openlock;
                sw.wnum = 3;
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick4()
    {
        if (isup)
        {
            if (CPC.coinscount >= 25)
            {
                CPC.coinscount -= 25;
                closedbtn[3].SetActive(false);
                openedwepon[3] = 1;
                pricelocks[3].image.sprite = openlock;
                sw.wnum = 4;
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick5()
    {
        if (isup)
        {
            if (CPC.coinscount >= 30)
            {
                CPC.coinscount -= 30;
                closedbtn[4].SetActive(false);
                openedwepon[4] = 1;
                pricelocks[4].image.sprite = openlock;
                sw.wnum = 5;
            }
            else descriptionpanel();
        }

    }

    void TaskOnClick11()
    {
        if (isup)
        {
            sw.wnum = 1;
        }
    }
    void TaskOnClick22()
    {
        if (isup)
        {
            sw.wnum = 2;
        }
    }
    void TaskOnClick33()
    {
        if (isup)
        {
            sw.wnum = 3;
        }
    }
    void TaskOnClick44()
    {
        if (isup)
        {
            sw.wnum = 4;
        }
    }
    void TaskOnClick55()
    {
        if (isup)
        {
            sw.wnum = 5;
        }
    }
    void descriptionpanel()
    {
        descpanel.SetActive(true);
    }


    void TaskOnClick1m()
    {
        if (isup)
        {
            if (CPC.coinscount >= 5)
            {
                CPC.coinscount -= 5;
                closedbtn1[0].SetActive(false);
                pricelocks1[0].image.sprite = openlock;
                LifesNum++;

                for (int i = 0; i < closedbtn1.Length; i++)
                {
                    if (i != 0) closedbtn1[i].SetActive(true);
                }
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick2m()
    {
        if (isup)
        {
            if (CPC.coinscount >= 7)
            {
                CPC.coinscount -= 7;
                closedbtn1[1].SetActive(false);
                pricelocks1[1].image.sprite = openlock;
                StopTraps++;

                for (int i = 0; i < closedbtn1.Length; i++)
                {
                    if (i != 1) closedbtn1[i].SetActive(true);
                }
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick3m()
    {
        if (isup)
        {
            if (CPC.coinscount >= 10)
            {
                CPC.coinscount -= 10;
                closedbtn1[2].SetActive(false);
                pricelocks1[2].image.sprite = openlock;
                checkPoint++;

                for (int i = 0; i < closedbtn1.Length; i++)
                {
                    if (i != 2) closedbtn1[i].SetActive(true);
                }
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick4m()
    {
        if (isup)
        {
            if (CPC.coinscount >= 12)
            {
                CPC.coinscount -= 12;
                closedbtn1[3].SetActive(false);
                pricelocks1[3].image.sprite = openlock;
                birdView++;

                for (int i = 0; i < closedbtn1.Length; i++)
                {
                    if (i != 3) closedbtn1[i].SetActive(true);
                }
            }
            else descriptionpanel();
        }
    }
    void TaskOnClick5m()
    {
        if (isup)
        {
            if (CPC.coinscount >= 17)
            {
                CPC.coinscount -= 17;
                closedbtn1[4].SetActive(false);
                pricelocks1[4].image.sprite = openlock;
                lowerWalls++;

                for (int i = 0; i < closedbtn1.Length; i++)
                {
                    if(i!= 4)closedbtn1[i].SetActive(true);
                }
            }
            else descriptionpanel();
        }

    }

    void TaskOnClick11m()
    {
        if (isup)
        {
            LifesNum++;
        }
    }
    void TaskOnClick22m()
    {
        if (isup)
        {
            StopTraps++;
        }
    }
    void TaskOnClick33m()
    {
        if (isup)
        {
            checkPoint++;
        }
    }
    void TaskOnClick44m()
    {
        if (isup)
        {
            birdView++;
        }
    }
    void TaskOnClick55m()
    {
        if (isup)
        {
            lowerWalls++;
        }
    }
}
