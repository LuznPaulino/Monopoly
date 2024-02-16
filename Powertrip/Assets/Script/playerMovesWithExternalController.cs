using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovesWithExternalController : MonoBehaviour
{
    PlayerInput thePlayerMovementController;
    Vector2 playerMovementVector;
    // Start is called before the first frame update
    void Awake()
    {
        thePlayerMovementController = GetComponent<PlayerInput>();
        thePlayerMovementController.onActionTriggered += playerMoving;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerMovementVector.x > 0.5)
        {
            GameObject.FindWithTag("Player").GetComponent<Transform>().Translate(0.01f * Vector2.right);
        }
        if (playerMovementVector.x < -0.5)
        {
            GameObject.FindWithTag("Player").GetComponent<Transform>().Translate(0.01f * Vector2.left);
        }
    }

    private void playerMoving(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            playerMovementVector = obj.ReadValue<Vector2>();
        }
        if (obj.canceled)
        {
            playerMovementVector = new Vector2(0, 0);
        }
    }
}
