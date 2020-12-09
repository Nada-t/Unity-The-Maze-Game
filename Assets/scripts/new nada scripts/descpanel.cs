using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class descpanel : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        this.gameObject.SetActive(false);
       // Debug.Log("You have clicked the button!");
    }
}
