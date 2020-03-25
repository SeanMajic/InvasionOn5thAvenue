using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject waveCompleteLabel;
    [SerializeField] GameObject loseLostLabel;
    int numberOfAttackers = 0;
    bool levelTimeFinished = false;
    [SerializeField] float timeUntillWaveCompleteSoundPlays = 2f;

    private void Start()
    {
        waveCompleteLabel.SetActive(false);
        loseLostLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if(numberOfAttackers <=0 && levelTimeFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
        
    }

    IEnumerator HandleWinCondition()
    {
        waveCompleteLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(timeUntillWaveCompleteSoundPlays);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void HandleLoseCondition()
    {
        loseLostLabel.SetActive(true);
      // Time.timeScale = 0;
    }

    public void LevelTimerFinished()
    {
        levelTimeFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }

 
}


