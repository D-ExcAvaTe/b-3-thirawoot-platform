using System.Collections;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private float destroyDelay = 3f;
    private void Start()
    {
        StartCoroutine(DestroyDelay());
    }
    private void Update()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    private IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(destroyDelay);
    }

    public override void OnHitWIthCharacter(Character character)
    {
    }

    public override void Move()
    {
    }
}
