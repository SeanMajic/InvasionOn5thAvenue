using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderLoseAnim : MonoBehaviour
{

    GameHealth gameHealths;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
      anim = gameObject.GetComponent<Animator>();
        gameHealths = FindObjectOfType<GameHealth>();

    }

    public void KillAllDefenders()
    {
        if (gameHealths.gameHealth <= 0)
        {
            anim.SetBool("isDead", true);
            Debug.Log("KILLALLDEFENDERSFFS");

        }
    }


}
