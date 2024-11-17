using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void Initialize(int _health)
    {
        slider.maxValue = _health;
        slider.value = _health;
    }
    public void UpdateHealthBar(int _health)
    {
        slider.value = _health;
    }
}
