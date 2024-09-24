using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class Crocodile : Enemy //inherit จาก Enemy 
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;

    public override void Behavior() //override Behavior
    {
        Debug.Log("<color=#B4FF94>Crocodile</color>");
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
