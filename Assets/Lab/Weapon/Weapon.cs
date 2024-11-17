using System;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected Character owner;
    [SerializeField] protected int damage;
    
    public int Damage
    {
        get => damage;
        set => damage = value;
    }
    
    protected virtual void Start()
    {
        Move();
    }

    public void Init(int _damage, Character _owner)
    {
        damage = _damage;
        owner = _owner;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Character newChar = other.GetComponent<Character>();
        if (newChar != null) OnHitWIthCharacter(newChar);
    }

    public abstract void OnHitWIthCharacter(Character character);

    public abstract void Move();

    public int GetShootDirection()
    {
        if (owner == null) return 1;
        if (owner.transform.localScale.x < 0)
            return -1;
        return 1;
    }

}
