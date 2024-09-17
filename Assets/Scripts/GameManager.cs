using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public InputManager inputManager { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        inputManager = new InputManager();
    }
}
