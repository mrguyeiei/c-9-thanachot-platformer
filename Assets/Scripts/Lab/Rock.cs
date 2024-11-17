using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rock : Weapon
{

    
    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDiection() *100, 200);
        Damage = 20;
        Move();
    }


    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    public override void Move()
    {
        rb2d.AddForce(force);
        //Debug.Log("Rock is Moveing with rigidbody force");
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
        //Console.WriteLine($"{this.name} : Overriding OnHitWith(Character)");
    }
}
