﻿/*
 * BulletController.cs
 * Joon Young Sun
 * 101216511
 * 2020-10-21
 * Controls Bullet Movement
 * Revision:
 * Changed it's movement from vertical to horizontal
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Either move towards right from the player
    private void _Move()
    {
        transform.position += new Vector3(verticalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    // Resets the bullet once it reaches the given boundary
    private void _CheckBounds()
    {
        if (transform.position.x > verticalBoundary + 10)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    // Resets the bullet once it touches the enemy
    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
