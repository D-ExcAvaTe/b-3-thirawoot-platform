using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;

    private void Start()
    {
        Init(30, 10);
        Debug.Log($"ant health = {Health}");
    }

    public override void Behavior()
    {
        rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);

        if (rb2D.position.x <= movePoints[0].position.x && velocity.x < 0)
            Flip();
        else if (rb2D.position.x >= movePoints[1].position.x && velocity.x > 0)
            Flip();

    }
    private void FixedUpdate()
    {
        Behavior();
    }
    private void Flip()
    {

        velocity.x *= -1;
        
        Vector2 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;
    }
}
