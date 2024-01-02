using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    public event Action<AttackData> OnClick;

    [SerializeField] private TMP_Text _name;

    private AttackData _attack;
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Action);
    }

    public void Init(AttackData attack)
    {
        _attack = attack;
        _name.text = _attack.Name;
    }

    private void Action()
    {
        OnClick?.Invoke(_attack);
    }
}
