using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorMovement : MonoBehaviour
{
    Vector2 cursorPlaceOnScreen;
    ThePlayerControls playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController.CursorMoveAround.CursorMoves.performed += test => cursorPlaceOnScreen = test.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   void TheCursor()
    {
        
    }
}
