using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

   
    [SerializeField] float minSpawnDelay = 3f;
    [SerializeField] float maxSpawnDelay = 9f;
    [SerializeField] Attacker[] attackerArray;

    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {

       while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }


    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerArray.Length);
        Spawn(attackerArray[attackerIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate
          (myAttacker, transform.position, transform.rotation)
          as Attacker;
        newAttacker.transform.parent = transform;
    }
}
