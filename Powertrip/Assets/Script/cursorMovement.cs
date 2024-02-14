using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cursorMovement : MonoBehaviour
{
    Vector2 cursorPlaceOnScreen;
    Vector2 whereToPlaceCursor;
    PlayerInput playerController;
    public bool disableCursor;
    // Start is called before the first frame update

    void Awake()
    {
        playerController = GetComponent<PlayerInput>();
        playerController.onActionTriggered += playerMovesCursor;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<PlayerInput>().GetDevice<Mouse>() != null)
        {
            GameObject.Find("pointer").GetComponent<Transform>().position = new Vector3(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x, GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y, 0);
        }
        if (this.GetComponent<PlayerInput>().GetDevice<Mouse>() == null)
        {
            if (cursorPlaceOnScreen.x > 0.5)
            {
                if (GameObject.Find("Main Camera").GetComponent<Camera>().scaledPixelWidth > GameObject.Find("Main Camera").GetComponent<Camera>().WorldToScreenPoint(GameObject.Find("pointer").GetComponent<Transform>().position).x)
                {
                    GameObject.Find("pointer").GetComponent<Transform>().Translate(0.01f * Vector2.right);
                }
            }
            if (cursorPlaceOnScreen.x < -0.5)
            {
                if (0 < GameObject.Find("Main Camera").GetComponent<Camera>().WorldToScreenPoint(GameObject.Find("pointer").GetComponent<Transform>().position).x)
                {

                    GameObject.Find("pointer").GetComponent<Transform>().Translate(0.01f * Vector2.left);
                }
            }
        }
    }

    private void playerMovesCursor(InputAction.CallbackContext obj)
    {
       if (this.GetComponent<PlayerInput>().GetDevice<Mouse>() == null) {
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
}
