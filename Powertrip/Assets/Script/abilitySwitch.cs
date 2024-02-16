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
    PlayerInput thePlayerInput;
    // Start is called before the first frame update

    void Awake()
    {
        thePlayerInput = GetComponent<PlayerInput>();
        playerControl = new ThePlayerControls();
        playerControl.thePlayer.Enable();
        playerControl.thePlayer.leftAbilitySwitch.performed += playerLeftAbilitySwitch;
        playerControl.thePlayer.rightAbilitySwitch.performed += playerRightAbilitySwitch;
    }


    void Start()
    {
        currentAbility = currentAbilities[0];
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void playerLeftAbilitySwitch(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            currentAbility = currentAbilities[0];
        }
    }

    private void playerRightAbilitySwitch(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            currentAbility = currentAbilities[1];
        }
    }


}
