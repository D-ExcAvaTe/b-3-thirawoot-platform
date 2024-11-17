using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    [SerializeField] private int damageHit; //"Tour pair"
    public int DamageHit //properties to get/set with "Tour pair"
    {
        get { return damageHit; }
        set { damageHit = value; }
    }
    private void Start()
    {
        Behavior();

        Debug.Log("(Enemy)");
        Debug.Log("<color=#94C2FF>เ</color><color=#8DC5FF>ร</color><color=#86C8FF>า</color><color=#80CBFF>ร</color><color=#79CFFF>ั</color><color=#73D2FF>ก</color><color=#6CD5FF>จ</color><color=#65D8FF>า</color><color=#68DEEC>ร</color><color=#6BE3D9>เ</color><color=#6EE9C6>ห</color><color=#71EEB3>ม</color><color=#74F4A0>ี</color><color=#77F98D>ย</color><color=#7AFE7A>ว</color>");
        Debug.Log("<color=#FDFF94>เ</color><color=#FDE98D>ร</color><color=#FDD386>า</color><color=#FDBD80>ร</color><color=#FEA779>ั</color><color=#FE9173>ก</color><color=#FE7B6C>จ</color><color=#FE6565>า</color><color=#FE687A>ร</color><color=#FE6B8E>เ</color><color=#FE6EA2>ห</color><color=#FE71B7>ม</color><color=#FE74CB>ี</color><color=#FE77DF>ย</color><color=#FE7AF3>ว</color>");

    }
    public abstract void Behavior();
}
