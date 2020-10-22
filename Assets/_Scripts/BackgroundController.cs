﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Source File Name: BackgroundController.cs
* Student Name: Matthew Makepeace
* Student ID: 101179668
* Date Last Modified: 10/21/2020
* Program Description: Background Controls, resets the background posion once it's offbounds.

* Modifications: Changed the background to move horizontally to left of the screen.
*/

public class BackgroundController : MonoBehaviour
{

    //public float verticalSpeed;
    //public float verticalBoundary;
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
