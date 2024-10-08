using UnityEngine;

public class Banana : Weapon
{
    [SerializeField] private float speed;

    protected override void Start()
    {
        Damage = 30;
        speed = 4;
        base.Start();
    }

    public override void OnHitWIthCharacter(Character character)
    {
    }

    public override void Move()
    {
        Debug.Log($"Banana is moving with Transform ด้วยความเร็วคงที่ (speed:{speed})");
    }
}
