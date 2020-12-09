using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkpoint : MonoBehaviour
{
    public List<Transform> CPoints;
    public Text checkpointText;
    int validation=0 ;
    collectablesPanelController CPC;
    Weaponspanel wp;

    // Start is called before the first frame update
    void Start()
    {
        checkpointText.text = "Checkpoint saved";
        checkpointText.enabled = false;
        CPoints = new List<Transform>();
        CPC = GameObject.FindGameObjectWithTag("collectablesPanel").GetComponent<collectablesPanelController>();
        wp = GameObject.FindGameObjectWithTag("Weaponspanel").GetComponent<Weaponspanel>();
    }

    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.P) && wp.checkPoint > 0)
        {
            if(validation > 0)
            {
                transform.position = CPoints[0].position;
                transform.position += new Vector3(0, 0, 5);
            }
          
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "checkPoint" )
        {
            StartCoroutine("showText");
    
            CPoints.Insert(0, collision.transform);
            validation++;
            if (validation > 3)
            {
                CPoints.RemoveAt(2);
            }
            
        }
    }

    IEnumerator showText()
    {
        checkpointText.enabled = true;
        yield return new WaitForSeconds(2f);
        checkpointText.enabled = false;
    }

}
