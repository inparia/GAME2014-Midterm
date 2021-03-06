﻿/*
 * BackgroundController.cs
 * Joon Young Sun
 * 101216511
 * 2020-10-21
 * Controls Background Movement
 * Revision:
 * Changed it's movement from right to left
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame

    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f);
    }

    // Move toward leftside from the rightside
    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background's right side is completely out of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
