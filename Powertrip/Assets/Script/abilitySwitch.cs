using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitySwitch : MonoBehaviour
{
    string[] theAbilities = { "Debt Collector", "The Pocketbook", "The Coin Flip" };
    public string[] currentAbilities = { "The Coin Flip", "The Pocketbook" };
    public string currentAbility;
    // Start is called before the first frame update
    void Start()
    {
        currentAbility = currentAbilities[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Left Ability"))
        {
            currentAbility = currentAbilities[0];
        }
        if (Input.GetButtonDown("Right Ability"))
        {
            currentAbility = currentAbilities[1];
        }

    }
}
