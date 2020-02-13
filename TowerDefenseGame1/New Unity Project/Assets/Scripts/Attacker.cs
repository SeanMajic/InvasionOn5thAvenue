using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range(0f, 5f)] [SerializeField] float currentSpeed = 1f;

    Health health;


    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        health.isDead = false;
    }


    // Update is called once per frame
    void Update()

        {

        if (health.isDead == false) 
            {

            transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);

            }

        }

    public void SetMovementSpeed(float speed)
    {

        {
            currentSpeed = speed;
        }
    }

   
}




