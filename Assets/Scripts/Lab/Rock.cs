using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public void Start()
    {
        Damage = 40;
        Move();
    }


    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    public override void Move()
    {
        Debug.Log("Rock is Moveing with rigidbody force");
    }
    public override void OnHitWith()
    {

    }
}
