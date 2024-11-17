using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;

    protected override void Start()
    {
        Damage = 40;
        base.Start();

        rb2d.AddForce(force);
    }

    public override void OnHitWIthCharacter(Character character)
    {
        Player player = character.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }

    public override void Move()
    {
        Debug.Log($"Rock is moving ด้วย RigidBody: force({force}))");
    }
}
