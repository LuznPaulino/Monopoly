using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cursorMovement : MonoBehaviour
{
    Vector2 cursorPlaceOnScreen;
    Vector2 whereToPlaceCursor;
    ThePlayerControls thePlayerCanControl;
    public bool disableCursor;
    // Start is called before the first frame update

    void Awake()
    {
        thePlayerCanControl = new ThePlayerControls();
        thePlayerCanControl.thePlayer.Enable();
        thePlayerCanControl.thePlayer.CursorMoves.performed += playerMovesCursor;
        thePlayerCanControl.thePlayer.CursorMovesTwo.performed += playerMovesCursorTwo;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void playerMovesCursorTwo(InputAction.CallbackContext obj)
    {
        GameObject.Find("pointer").GetComponent<Transform>().position = new Vector3(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x, GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y, 0);
    }

    private void playerMovesCursor(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            cursorPlaceOnScreen = obj.ReadValue<Vector2>();
        }
        if (obj.canceled)
        {
            cursorPlaceOnScreen = new Vector2(0, 0);
        }

    }
}
