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
        Debug.Log("<color=#94C2FF>�</color><color=#8DC5FF>�</color><color=#86C8FF>�</color><color=#80CBFF>�</color><color=#79CFFF>�</color><color=#73D2FF>�</color><color=#6CD5FF>�</color><color=#65D8FF>�</color><color=#68DEEC>�</color><color=#6BE3D9>�</color><color=#6EE9C6>�</color><color=#71EEB3>�</color><color=#74F4A0>�</color><color=#77F98D>�</color><color=#7AFE7A>�</color>");
        Debug.Log("<color=#FDFF94>�</color><color=#FDE98D>�</color><color=#FDD386>�</color><color=#FDBD80>�</color><color=#FEA779>�</color><color=#FE9173>�</color><color=#FE7B6C>�</color><color=#FE6565>�</color><color=#FE687A>�</color><color=#FE6B8E>�</color><color=#FE6EA2>�</color><color=#FE71B7>�</color><color=#FE74CB>�</color><color=#FE77DF>�</color><color=#FE7AF3>�</color>");

    }
    public abstract void Behavior();
}
