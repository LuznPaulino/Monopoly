using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerHealthDeducted(int healthRemoved)
    {
        playerHealth -= healthRemoved;
    }

    public void playerHealthAddition(int healthGained)
    {
        playerHealth += healthGained;
    }
}
