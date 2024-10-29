using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    GameObject Bullet { get; set; }
    float AttackRange { get; set; }
    float AttackDelay { get; set; }
    float AttackTimer { get; set; }

    void Shoot();
}
