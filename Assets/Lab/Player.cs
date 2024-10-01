using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Player : Character
{
    private void Start()
    {
        Init(120);
    }
    public override bool IsDead()
    {
        return base.IsDead();
    }

    public override void TakeDamage(int damageHit)
    {
        base.TakeDamage(damageHit);
    }
    private void Behavior()
    {

    }
    private void Shoot()
    {

    }
    private void OnHitWithEnemy(Enemy enemy)
    {

    }
}
