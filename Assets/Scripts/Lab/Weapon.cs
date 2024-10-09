using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    public string ownerIshootable;
    public abstract void OnHitWith();
    public abstract void Move();
    public int GetShootDiection()
    {
        return 1;
    }

    
}
