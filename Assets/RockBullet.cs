using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBullet : MonoBehaviour
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
}
