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
        Debug.Log("<color=#94C2FF>à</color><color=#8DC5FF>Ã</color><color=#86C8FF>Ò</color><color=#80CBFF>Ã</color><color=#79CFFF>Ñ</color><color=#73D2FF>¡</color><color=#6CD5FF>¨</color><color=#65D8FF>Ò</color><color=#68DEEC>Ã</color><color=#6BE3D9>à</color><color=#6EE9C6>Ë</color><color=#71EEB3>Á</color><color=#74F4A0>Õ</color><color=#77F98D>Â</color><color=#7AFE7A>Ç</color>");
        Debug.Log("<color=#FDFF94>à</color><color=#FDE98D>Ã</color><color=#FDD386>Ò</color><color=#FDBD80>Ã</color><color=#FEA779>Ñ</color><color=#FE9173>¡</color><color=#FE7B6C>¨</color><color=#FE6565>Ò</color><color=#FE687A>Ã</color><color=#FE6B8E>à</color><color=#FE6EA2>Ë</color><color=#FE71B7>Á</color><color=#FE74CB>Õ</color><color=#FE77DF>Â</color><color=#FE7AF3>Ç</color>");

    }
    public abstract void Behavior();
}
