using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    private GameObject upperWall;
    private GameObject lowerWall;
    private float upperWallY;
    private float lowerWallY;

    private void Start()
    {
        upperWall = GameObject.FindGameObjectWithTag("Upper Wall");
        lowerWall = GameObject.FindGameObjectWithTag("Lower Wall");
        upperWallY = upperWall.transform.position.y;
        lowerWallY = lowerWall.transform.position.y;
    }
    
    // Update is called once per frame
    private void Update()
    {
        Vector3 currentPos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float y = mousePos.y;
        if (y + (transform.localScale.y / 2) > upperWallY - (transform.localScale.y / 2) + 0.2f)
        {
            y = upperWallY - transform.localScale.y + 0.2f;
        }
        else if (y - (transform.localScale.y / 2) < lowerWallY + (transform.localScale.y / 2) - 0.2f)
        {
            y = lowerWallY + transform.localScale.y - 0.2f;
        }
        transform.position = new Vector2(currentPos.x, y);

        // if (mousePos.y > 0)
        // {
        //     _direction = Vector2.up;
        // }
        // else if (mousePos.y < 0)
        // {
        //     _direction = Vector2.down;
        // }
        // else
        // {
        //     _direction = Vector2.zero;
        // }
    }

    // private void FixedUpdate()
    // {
    //     if (_direction.sqrMagnitude != 0)
    //     {
    //         _rigidbody.AddForce(_direction * this.speed);
    //     }
    // }
}
