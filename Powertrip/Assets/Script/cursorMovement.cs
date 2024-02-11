using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cursorMovement : MonoBehaviour
{
    Vector2 cursorPlaceOnScreen;
    ThePlayerControls playerController;
    // Start is called before the first frame update

    void Awake()
    {
        playerController = new ThePlayerControls();
        playerController.CursorMoveAround.CursorMoves.performed += test => cursorPlaceOnScreen = test.ReadValue<Vector2>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(cursorPlaceOnScreen);
    }

   void TheCursor()
    {
        
    }
}
