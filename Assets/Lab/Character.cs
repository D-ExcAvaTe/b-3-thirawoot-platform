using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    
    private int health;
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    private int damage;
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public Animator anim;
    public Rigidbody2D rb2D;

    public virtual bool IsDead()
    {
        if (Health <= 0) return true;
        else return false;
    }

    public virtual void TakeDamage(int _damage)
    {
        Health -= _damage;
        healthBar.UpdateHealthBar(_damage);
    }
    public void Init(int _health)
    {
        Health = _health;
        healthBar.Initialize(_health);
    }
}
