using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rigibody;
    private Vector2 moveDirection;
    [SerializeField] private int velocity;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovementHandler();
    }

    private void MovementHandler()
    {
        moveDirection = GameManager.instance.inputManager.DirMove;
        Vector2 dirToMove = new Vector2(moveDirection.x * velocity, moveDirection.y * velocity);
        rigibody.velocity = dirToMove;
    }
}
