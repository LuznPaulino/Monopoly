using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cursorMovement : MonoBehaviour
{
    Vector2 cursorPlaceOnScreen;
    PlayerInput playerController;
    // Start is called before the first frame update

    void Awake()
    {
        playerController = GetComponent<PlayerInput>();
        playerController.onActionTriggered += playerMoves;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePresent)
        {
            GameObject.Find("pointer").GetComponent<Transform>().position = new Vector3(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).x, GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition).y, 0);
        }
        if (!Input.mousePresent)
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

    private void playerMoves(InputAction.CallbackContext obj)
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
