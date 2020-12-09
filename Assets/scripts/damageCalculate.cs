using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class damageCalculate : MonoBehaviour
{
    public float health = 100f;
    public Image healthBar;
    public Text healthNumberText;
    public float lerpSpeed;
    public GameObject gameOverPanal;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
        healthNumberText.text = Mathf.Round(health).ToString();
        healthBar.fillAmount = health / 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthBarManager();

        if (health <= 0)
        {
            gameOverPanal.SetActive(true);
            isDead = true;
        }
    }

    public void healthBarManager()
    {
        health = Mathf.Clamp(health, 0, 100);
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health / 100, Time.deltaTime * lerpSpeed);
        healthNumberText.text = Mathf.Round(healthBar.fillAmount * 100f).ToString(); 
    }

  
}
