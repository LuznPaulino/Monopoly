using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class abilitySwitch : MonoBehaviour
{
    string[] theAbilities = { "Debt Collector", "The Pocketbook", "The Coin Flip" };
    public string[] currentAbilities = { "The Coin Flip", "The Pocketbook" };
    public string currentAbility;
    ThePlayerControls playerControl;
    // Start is called before the first frame update

    void Awake()
    {
        playerControl = new ThePlayerControls();
    }


    void Start()
    {
        currentAbility = currentAbilities[0];
    }

    // Update is called once per frame
    void Update()
    {
        print(playerControl.thePlayer.AbilitySwitch.IsPressed());
        if (Input.GetButtonDown("Left Ability"))
        {
            currentAbility = currentAbilities[0];
        }
        if (Input.GetButtonDown("Right Ability"))
        {
            currentAbility = currentAbilities[1];
        }

    }


    private void playerAbilitySwitch(InputAction.CallbackContext obj)
    {
        print(obj.ReadValue<Vector2>());
    }
}
