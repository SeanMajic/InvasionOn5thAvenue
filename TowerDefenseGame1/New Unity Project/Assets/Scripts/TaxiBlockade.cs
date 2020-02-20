using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiBlockade : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        Attacker attacker = otherCollider.GetComponent<Attacker>();

        if(attacker)
        {
            //an animation of some kind
        }
    }
}
