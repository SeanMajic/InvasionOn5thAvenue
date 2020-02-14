using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;

    Animator anim;



    private void Start()
    {

        anim = GetComponent<Animator>();
        SetLaneSpawner();
    }

    private void Update()
    {
        if(IsAttackerInLane())
        {
            anim.SetBool("isShooting", true);
        }
        else
        {
            anim.SetBool("isShooting", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();


        foreach (AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough =
                 (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }

        }
    }

    private bool IsAttackerInLane()
    {

        if (myLaneSpawner.transform.childCount <=0)
        {
            return false;
        }

        else
        {
            return true;
        }
      


    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
}
