using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{

    [SerializeField] private float speed;


    public void Start()
    {
        Damage = 30;
        speed = 4.0f * GetShootDiection();
        Move();

    }


    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        //Debug.Log($"{this.name} moving with transform constant speed");

    }

    private void FixedUpdate()
    {
        Move();
    }



    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }
        //Console.WriteLine()
    }

}