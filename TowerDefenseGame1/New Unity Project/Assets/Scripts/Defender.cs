using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int dollarCost = 100;
    Animator anim;

  

    private void Update()
    {
        anim = GetComponent<Animator>();
    }

    public int GetDollarCost()
    {
        return dollarCost;
    }

    public void AddDollars(int amount)
    {
        FindObjectOfType<DollarDisplay>().AddDollars(amount);

    }

    public void FindAndKillAllDefenders()
    {


        GameObject[] defenders = GameObject.FindGameObjectsWithTag("Defender");
        foreach (GameObject defender in defenders)
        {
            anim.SetBool("isDead", true);
        }

    }

}
