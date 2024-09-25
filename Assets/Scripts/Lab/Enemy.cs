using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
   private int demageHit;
   public int DemageHit
    {
        get 
        {
            return demageHit;
        }
        set
        {
            demageHit = value;
        }
    }


    private void Start()
    {
        Behavior();
    }


    public abstract void Behavior();
   

   
}
