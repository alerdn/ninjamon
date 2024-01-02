using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsUI : MonoBehaviour
{
    [SerializeField] private Inputs _inputs;
    [SerializeField] private AttackButton _attackButton;

    private void Start()
    {
       _attackButton.OnClick += _inputs.Attack;
    }
}
