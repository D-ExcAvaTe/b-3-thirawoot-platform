using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Enemy : Character
{
   protected int DamageHit
    {
        get { return DamageHit; }
        set { DamageHit = value; }
    }

   public override bool IsDead()
    {
        return base.IsDead();
    }

    public override void TakeDamage(int _damage)
    {
        base.TakeDamage(_damage);
    }
    public virtual void Behavior()
    {

    }
}
