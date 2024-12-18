﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollarDisplay : MonoBehaviour
{

    [SerializeField] int dollars = 10000;
    Text dollarText;
    


    void Start()
    {
        dollarText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        dollarText.text = dollars.ToString();
    }

    public bool HaveEnoughDollars(int amount)
    {
        return dollars >= amount;
    }

    public void AddDollars(int amount)
    {
        dollars += amount;
        UpdateDisplay();
    }

    public void SpendDollars(int amount)
    {
        if(dollars >= amount)
        {
            dollars -= amount;
            UpdateDisplay();
        }
      
    }
    
}
