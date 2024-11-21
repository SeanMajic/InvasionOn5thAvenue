using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    Animator anim;

    [SerializeField] float enemyHealth = 100f;
    [SerializeField] float deathAnimWaitTime = 2f;


    private void Start()
    {
        anim = GetComponent<Animator>();

    }

 

        public void DealDamage(float damage)
        {

            enemyHealth -= damage;

            if (enemyHealth <= 0)
            {

                anim.SetBool("isDead", true);
                StartCoroutine(TimeForAnimToPlayOut());
            }
        }

        IEnumerator TimeForAnimToPlayOut()
        {
            yield return new WaitForSeconds(deathAnimWaitTime);
            Destroy(gameObject);
        }
    }

