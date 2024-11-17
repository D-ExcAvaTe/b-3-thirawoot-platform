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
        Init(120, 15);
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
                GameObject bullet = Instantiate(Bullet, attackPosition.position, Quaternion.identity);
                Weapon weapon = bullet.GetComponent<Weapon>();

                if (weapon != null) weapon.Init(Damage, this);
                
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
