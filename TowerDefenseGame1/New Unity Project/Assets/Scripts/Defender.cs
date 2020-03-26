using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int dollarCost = 100;
    Animator anim;

    public Defender()
    {
        
    }

    private void Update()
    {
        
    }

    public int GetDollarCost()
    {
        return dollarCost;
    }

    public void AddDollars(int amount)
    {
        FindObjectOfType<DollarDisplay>().AddDollars(amount);
    }

    public void KillDefender()
    {
        GetComponent<Animator>().SetBool("isDead", true);
    }
}
