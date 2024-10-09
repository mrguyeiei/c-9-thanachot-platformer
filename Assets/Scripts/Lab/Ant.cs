using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{

    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        //Init(10);
        Debug.Log("Ant health : " + Health);

        Behavior();
    }

    /*public void Init(int newHealth)
    {
        Health = newHealth;
    }*/

    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            FlipCharacter();
        }
        else if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            FlipCharacter();
        }
    }

    private void FlipCharacter()
    {
        velocity *= -1;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

}
