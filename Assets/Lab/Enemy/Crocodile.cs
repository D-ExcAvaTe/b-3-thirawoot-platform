using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

internal class Crocodile : Enemy, IShootable //inherit �ҡ Enemy 
{
    [field: SerializeField] public GameObject Bullet { get; set; }

    [field: SerializeField] public float AttackRange { get; set; }

    [field: SerializeField] public float AttackDelay { get; set; }

    [field: SerializeField] public float AttackTimer { get; set; }

    [SerializeField] private Transform attackPosition;
    public Player player;

    public override void Behavior() //override Behavior
    {
        Vector2 direction = player.transform.position - this.transform.position;

        float distance = direction.magnitude;

        if (distance <= AttackRange) Shoot();
    }

    void Start()
    {
        Init(50);
    }
    private void Update()
    {
        AttackTimer -= Time.deltaTime;

        Behavior();
    }

    void Shoot()
    {
        if(AttackTimer<=0)
        {
            Instantiate(Bullet, attackPosition.position, Quaternion.identity, attackPosition);
            AttackTimer = AttackDelay;
        }
    }

    public override bool IsDead()
    {
        return base.IsDead();
    }

    public override void TakeDamage(int damageHit)
    {
        base.TakeDamage(damageHit);
    }

    void IShootable.Shoot()
    {
        throw new System.NotImplementedException();
    }
}
