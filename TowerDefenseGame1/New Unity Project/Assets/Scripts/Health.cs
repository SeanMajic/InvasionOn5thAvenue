using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    Animator anim;

    [SerializeField] float health = 100f;
    [SerializeField] float deathAnimWaitTime = 1f;

    bool isDead = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void DealDamage(float damage)
    {

        health -= damage;

        if (health <= 0)
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

