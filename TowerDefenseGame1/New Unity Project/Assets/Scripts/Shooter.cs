using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {
        if(IsAttackerInLane())
        {
            Debug.Log("Shoot");
            //TODO change anim state to shooting
        }
        else
        {
            Debug.Log("Idle");

            //TODO change anim state to idle
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough =
                (Mathf.Abs(spawner.transform.position.y - transform.position.y)
                <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {

        if(myLaneSpawner.transform.childCount <=0)
        {
            return false;
        }

        else
        {
            return true;
        }
        // if my lane spawner child count is <=0 then return false
        // return false
        
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.Euler(0, 0, 0));
    }
}
