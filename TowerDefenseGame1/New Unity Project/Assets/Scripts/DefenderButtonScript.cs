using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButtonScript : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;


    private void OnMouseDown()
    {

        var buttons = FindObjectsOfType<DefenderButtonScript>();
        foreach(DefenderButtonScript button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);

    }
}
