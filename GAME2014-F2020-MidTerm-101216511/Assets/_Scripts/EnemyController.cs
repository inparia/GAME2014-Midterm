/*
 * EnemyController.cs
 * Joon Young Sun
 * 101216511
 * 2020-10-21
 * Controls Enemy Movement
 * Revision:
 * Changed it's movement from horizontal to vertical
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Either move up or down based on it's direction
    private void _Move()
    {
        transform.position += new Vector3(0.0f, horizontalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check up boundary and change it's direction
        if (transform.position.y >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check down boundary and change it's direction
        if (transform.position.y <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
