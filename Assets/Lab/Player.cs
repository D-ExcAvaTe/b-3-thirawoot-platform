using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Player : Character,IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public float AttackRange { get; set; }
    [field: SerializeField] public float AttackDelay { get; set; }
    [field: SerializeField] public float AttackTimer { get; set; }

    [SerializeField] private Transform attackPosition;
    private void Start()
    {
        Init(120);
    }
    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (AttackTimer >= AttackDelay)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(Bullet, attackPosition.position, Quaternion.identity);
                AttackTimer = 0;
            }
        }
        else
        {
            AttackTimer += Time.deltaTime;
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
    private void Behavior()
    {

    }
    private void OnHitWithEnemy(Enemy enemy)
    {

    }

    void IShootable.Shoot()
    {
        throw new System.NotImplementedException();
    }
}
