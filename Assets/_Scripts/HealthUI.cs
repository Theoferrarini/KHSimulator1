using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;

    int CachedMaxHealth { get; set; }

    private void Start()
    {
        CachedMaxHealth = _playerHealth.CurrentHealth;
        _slider.maxValue = CachedMaxHealth;
        _playerHealth.HealthChanged += UpdateSlider;
        UpdateSlider(_playerHealth.CurrentHealth);
    }

    void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {CachedMaxHealth}";
    }

}
