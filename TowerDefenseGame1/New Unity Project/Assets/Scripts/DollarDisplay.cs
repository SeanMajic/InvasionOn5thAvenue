using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollarDisplay : MonoBehaviour
{

    [SerializeField] int dollars = 100;
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
