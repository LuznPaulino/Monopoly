using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitySwitch : MonoBehaviour
{
    string[] theAbilities = { "Debt Collector", "The Pocketbook", "The Coin Flip" };
    public string[] currentAbilities = { "Debt Collector", "The Pocketbook" };
    public string currentAbility;
    // Start is called before the first frame update
    void Start()
    {
        currentAbility = currentAbilities[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("E"))
        {
            currentAbility = currentAbilities[0];
        }
        if (Input.GetButtonDown("Q"))
        {
            currentAbility = currentAbilities[1];
        }

    }

    void chooseTwo (string choiceOne, string choiceTwo) {
        currentAbilities[0] = choiceOne;
        currentAbilities[1] = choiceTwo;
    }
}
