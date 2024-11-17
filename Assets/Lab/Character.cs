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
        healthBar.UpdateHealthBar(Health);
        
        if(IsDead()) Destroy(this.gameObject);
        
        Debug.Log($"{name} took {_damage} damage Hp:{Health}");
    }
    public void Init(int _health, int _damage)
    {
        Health = _health;
        Damage = _damage;
        healthBar.Initialize(Health);
    }
}
