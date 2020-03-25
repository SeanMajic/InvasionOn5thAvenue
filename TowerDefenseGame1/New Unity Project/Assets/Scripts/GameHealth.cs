using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHealth : MonoBehaviour
{



    Text healthText;
    [SerializeField] public int gameHealth = 10;
    [SerializeField] int damage = 1;
    [SerializeField] float defenderDeathAnim = 5f;




    Animator anim;

    private void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
    }
        
    private void UpdateDisplay()
    {
        healthText.text = gameHealth.ToString();
    }

    public void TakeLife()
    {
        gameHealth -= damage;
        UpdateDisplay();

        if (gameHealth <= 0)
        {
            FindObjectOfType<Defender>().FindAndKillAllDefenders();
            StartCoroutine(WaitForDefenderDeathAnimToPlayOut());
        }
        
    }

  


    IEnumerator WaitForDefenderDeathAnimToPlayOut()
     {
         yield return new WaitForSeconds(defenderDeathAnim);
        FindObjectOfType<LevelLoader>().LoadYouLose();
    } 

 

}
