using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Crocodile : Enemy //inherit จาก Enemy 
{
    [SerializeField] private GameObject rock;
    [SerializeField] private Transform attackPosition;

    [SerializeField] private float attackRange;
    [SerializeField] private float attackDelay;
    private float attackTimer;

    public Player player;

    private bool isFollowingPlayer;
    
    public override void Behavior() //override Behavior
    {
        Vector2 direction = player.transform.position - this.transform.position;

        float distance = direction.magnitude;

        if (distance <= attackRange)
        {
            Shoot();
            isFollowingPlayer = true;
        }
        else isFollowingPlayer = false;


        followPlayer();
    }

    private void Update()
    {
        attackTimer -= Time.deltaTime;

        Behavior();
    }

    void Shoot()
    {
        if(attackTimer<=0)
        {
            Instantiate(rock, attackPosition.position, Quaternion.identity, attackPosition);
            attackTimer = attackDelay;
        }
    }

    void followPlayer()
    {
        if (isFollowingPlayer)
        {
            //rb2D.MovePosition(player.transform.position);

            Vector2 playerPos = player.transform.position;
            float speed = 10f;
            Vector2 newPosition = Vector2.Lerp(transform.position, playerPos, speed * Time.deltaTime);
            rb2D.MovePosition(newPosition);
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

}
