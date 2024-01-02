using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    public event Action<AttackData> OnClick;

    [SerializeField] private AttackData attack;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void Start()
    {
        _button.onClick.AddListener(Action);
    }

    private void Action()
    {
        OnClick?.Invoke(attack);
    }
}
