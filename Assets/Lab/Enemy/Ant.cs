using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    /*private void FixedUpdate()
    {
        Behavior();
    }*/

    public override void Behavior()
    {
        Debug.Log("<color=#FDFF94>Ant</color>");
        // Move();

        //if (rb2D.position.x >= movePoints[1].position.x && velocity.x > 0)
        //    Flip();
    }
    private void Move()
    {
        rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
    }
    private void Flip()
    {

        velocity.x = -1;
        Vector2 charScale = transform.localScale;
        charScale.x -= 1;
        transform.localScale = charScale;
    }
}
