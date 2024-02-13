using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class cursorMovementY : MonoBehaviour
{
    Vector2 cursorPlaceOnScreen;
    PlayerInput playerController;

    void Awake()
    {
        playerController = GetComponent<PlayerInput>();
        playerController.onActionTriggered += playerMoves;
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
            if (cursorPlaceOnScreen.y > 0.5)
            {
                if (GameObject.Find("Main Camera").GetComponent<Camera>().scaledPixelHeight > GameObject.Find("Main Camera").GetComponent<Camera>().WorldToScreenPoint(GameObject.Find("pointer").GetComponent<Transform>().position).y)
                {
                    GameObject.Find("pointer").GetComponent<Transform>().Translate(0.01f * Vector2.up);
                }
            }
            if (cursorPlaceOnScreen.y < -0.5)
            {
                if (0 < GameObject.Find("Main Camera").GetComponent<Camera>().WorldToScreenPoint(GameObject.Find("pointer").GetComponent<Transform>().position).y)
                {
                    GameObject.Find("pointer").GetComponent<Transform>().Translate(0.01f * Vector2.down);
                }
            }
        }
    }

    private void playerMoves(InputAction.CallbackContext obj)
    {
        if (this.GetComponent<PlayerInput>().GetDevice<Mouse>() == null)
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
}
