using System.Collections;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private float destroyDelay = 3f;
    private int dir;
    
    private void Start()
    {
        StartCoroutine(DestroyDelay());
        dir = GetShootDirection();
    }
    private void Update()
    {
        rb.MovePosition(rb.position + (velocity * dir) * Time.fixedDeltaTime);
    }

    private IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(destroyDelay);
    }

    public override void OnHitWIthCharacter(Character character)
    {
        Enemy enemy = character.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }

    public override void Move()
    {
    }
}
