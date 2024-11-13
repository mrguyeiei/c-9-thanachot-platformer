using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }

    }

    public HeartBar healthBar;
    public Animator anim;
    public Rigidbody2D rb;

    public virtual void Init(int newHealth)
    {
        health = newHealth;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        healthBar.SetMaxHealth(health);
    }

    public bool Isdead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else return false;

    }
    public void TakeDamage(int damage)
    {
        Health -= damage;

        Isdead();

        healthBar.SetHealth(health);
    }
}

