using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Source File Name: BulletController.cs
 * Student Name: Matthew Makepeace
 * Student ID: 101179668
 * Date Last Modified: 10/21/2020
 * Program Description: Bullet Controls Script.

 * Modifications: Changed bullet to shoot horizontally towards the right, and changed the horizontalBoundary value.
 */

public class BulletController : MonoBehaviour, IApplyDamage
{
    //public float verticalSpeed;
    //public float verticalBoundary;
    public float horizontalSpeed;
    public float horizontalBoundary;
    
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

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

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
