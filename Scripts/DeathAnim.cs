using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour
{

    private Animator anim;
    

    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    void Update()
    {

        void TriggerDeathAnim();
        {
            Health.health <= 0;
            // trigger death animation
            // also stop animation from moving (attacker.cs)

        }


    }
}
