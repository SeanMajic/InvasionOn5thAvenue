using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int dollarCost = 100;


    public int GetDollarCost()
    {
        return dollarCost;
    }

    public void AddDollars(int amount)
    {
        FindObjectOfType<DollarDisplay>().AddDollars(amount);

    }

    

}
