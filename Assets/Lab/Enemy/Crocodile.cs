using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Crocodile : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;

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
