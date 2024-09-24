using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;
    public override void Behavior()
    {
        base.Behavior();
    }

    public override bool IsDead()
    {
        return base.IsDead();
    }

    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
    }
}
