using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameHealth : MonoBehaviour
{



    Text healthText;
    [SerializeField] public int gameHealth = 10;
    [SerializeField] int damage = 1;
    [SerializeField] float defenderDeathAnim = 5f;
   
   // Animator anim;

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
        if (gameHealth >= 0)
        {
            gameHealth -= damage;
            UpdateDisplay();

            if (gameHealth <= 0)
            {
                FindAndKillAllDefenders();
                StartCoroutine(WaitForDefenderDeathAnimToPlayOut());
            }
        }
    }

    public void FindAndKillAllDefenders()
    {
        GameObject.FindGameObjectsWithTag("Defender").
            Select(x => x.GetComponent<Defender>()).
            ToList().
            ForEach(x => x.KillDefender());

       /* var defenders = GameObject.FindGameObjectsWithTag("Defender").ToList();
        foreach(var defender in defenders)
        {
            var component = defender.GetComponent<Defender>();
            component.KillDefender();        
        }*/
    }

    IEnumerator WaitForDefenderDeathAnimToPlayOut()
     {
         yield return new WaitForSeconds(defenderDeathAnim);
        FindObjectOfType<LevelLoader>().LoadYouLose();
    }
}
