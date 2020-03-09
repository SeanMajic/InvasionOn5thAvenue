using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHealth : MonoBehaviour
{

    Text healthText;
    [SerializeField] int gameHealth = 10;
    [SerializeField] int damage = 1;
   // [SerializeField] float defenderDeathAnim = 5f;
    public bool gameIsOver = false;
    Animator anim;

    private void Start()
    {
        healthText = GetComponent<Text>();
        FindObjectOfType<Animator>();
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
            GetComponent<Defender>().LoseDeathAnimation();
           // StartCoroutine(WaitForDefenderDeathAnimToPlayOut());

        }
    }

    /*  IEnumerator WaitForDefenderDeathAnimToPlayOut()
     {
         yield return new WaitForSeconds(defenderDeathAnim);
         FindObjectOfType<LevelLoader>().LoadYouLose();
     }

    private void LoseDeathAnimation()
     {

         if (gameIsOver == true)
         {
             anim.SetBool("isDead", true);
         }

     } */

}
