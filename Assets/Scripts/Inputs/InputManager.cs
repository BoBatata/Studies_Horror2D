using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public InputControls inputControls;

    public Vector2 DirMove => inputControls.PlayerMovement.Walk.ReadValue<Vector2>();


    public InputManager()
    {
        inputControls = new InputControls();
        EnablePlayerMovement();
    }

    public void EnablePlayerMovement() => inputControls.PlayerMovement.Enable();

    public void DisablePlayerMovement() => inputControls.PlayerMovement.Disable();
}
