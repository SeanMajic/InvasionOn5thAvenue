using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienII : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {


        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<TaxiBlockade>())
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }

        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }


}
