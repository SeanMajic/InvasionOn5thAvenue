using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int dollarCost = 100;

    GameHealth gameHealth;

   public bool gameIsOver = false;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        gameHealth = GetComponent<GameHealth>();
    

    }

    public int GetDollarCost()
    {
        return dollarCost;
    }

    public void AddDollars(int amount)
    {
        FindObjectOfType<DollarDisplay>().AddDollars(amount);

    }

   public void LoseDeathAnimation()
    {

        
            anim.SetBool("isDead", true);
        
 
    } 
}
