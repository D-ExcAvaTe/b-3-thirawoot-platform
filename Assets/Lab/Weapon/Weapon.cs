using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected string owners;
    [SerializeField] private int damage;
    
    public int Damage
    {
        get => damage;
        set => damage = value;
    }
    
    protected virtual void Start()
    {
        Move();
    }

    public abstract void OnHitWIthCharacter(Character character);

    public abstract void Move();

    public int GetShootDirection()
    {
        return 1;
    }

}
