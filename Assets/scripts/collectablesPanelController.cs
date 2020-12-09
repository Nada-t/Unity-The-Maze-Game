using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectablesPanelController : MonoBehaviour
{
    public Text birdEyeText;
    public Text LifeText;   // needs configration
    public Text checkPointText;
    public Text lowerWallText;
    public Text trapsDisapleText;
    Animator panalAnimatior;
    bool panalState = false;    // false is hiding and true is showing 

 //   [HideInInspector]
    public int P_LifesNum = 0;
 //   [HideInInspector]
    public int P_StopTraps = 0;
 //   [HideInInspector]
    public int P_birdView = 0;
 //   [HideInInspector]
    public int P_lowerWalls = 0;
  //  [HideInInspector]
    public int P_checkPoint = 0;

    /// ///////////////////////////new//////////////////////////

    public Text coincounterText;
    public int coinscount = 0;

    /// ////////////////new////////////////////


    // Start is called before the first frame update
    void Start()
    {
        panalAnimatior = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        birdEyeText.text = "Bird Eye : "+ P_birdView.ToString();
        checkPointText.text = "checkPint : "+P_checkPoint.ToString();
        lowerWallText.text ="pass walls : "+ P_lowerWalls.ToString();
        trapsDisapleText.text = "Traps Disable : "+P_StopTraps.ToString();
        LifeText.text = "Lifes :"+ P_LifesNum.ToString();

        /// ///////////////////////////new//////////////////////////

        coincounterText.text = coinscount.ToString();

        //////////////////////////new//////////////////////

        if (Input.GetKeyDown(KeyCode.L)&& panalState)
        {
            panalAnimatior.SetBool("hiding", true);
            panalAnimatior.SetBool("showing", false);
            panalState = false;
            
        }else if(Input.GetKeyDown(KeyCode.L)&& !panalState)
        {
            panalAnimatior.SetBool("showing", true);
            panalAnimatior.SetBool("hiding", false);

            panalState = true;

        }


    }
}
