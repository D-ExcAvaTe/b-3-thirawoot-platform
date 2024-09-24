using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Character : MonoBehaviour
{
    private int health;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public Animator anim;
    public Rigidbody2D r2d;

    public virtual bool IsDead()
    {
        if (Health <= 0) return true;
        else return false;
    }

    public virtual void TakeDamage(int _damage)
    {
        Health -= _damage;
    }
}
