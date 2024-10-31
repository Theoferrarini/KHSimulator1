using System;
using TMPro;
using UnityEngine;

public class GoldUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityGold _entity;

    void Awake()
    {
        _entity.GoldChanged += UpdateText;
    }

    void UpdateText(int newGoldValue)
    {
        _text.text = $"gold : {newGoldValue}";
    }
}
