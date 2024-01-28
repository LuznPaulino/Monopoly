using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int playerHealth;
    public string[] theAbilities = { "Debt Collector", "The Pocketbook", "The Coin Flip" };
    public string currentAbility = "Debt Collector";
    public bool theCointFlipShield = false;
    public bool theCoinFlipCooldown = false;
    public bool debtCollectorCooldown= false;
    public bool pocketbookCooldown = false;

    public int whereAmI = 0;
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

    public void levelCompleted()
    {
        whereAmI = SceneManager.GetActiveScene().buildIndex;
    }
}
