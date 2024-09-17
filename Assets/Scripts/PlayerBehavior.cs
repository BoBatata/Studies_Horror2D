using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody2D rigibody;
    private Vector2 moveDirection;
    private Vector3 aimDirection;
    private Vector3 mousePos;
    [SerializeField] private int velocity;
    [SerializeField] private Transform aimTransform;

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovementHandler();
        VisionDirectionHandler();
    }

    private void VisionDirectionHandler()
    {
        mousePos = GameManager.instance.inputManager.mousePos;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 aimDirection = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void MovementHandler()
    {
        moveDirection = GameManager.instance.inputManager.DirMove;
        Vector2 dirToMove = new Vector2(moveDirection.x * velocity, moveDirection.y * velocity);
        rigibody.velocity = dirToMove;
    }
}
