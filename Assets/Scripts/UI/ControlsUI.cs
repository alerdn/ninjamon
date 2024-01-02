using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsUI : MonoBehaviour
{
    [SerializeField] private Inputs _inputs;
    [SerializeField] private AttackButton _attackButtonPrefab;
    [SerializeField] private Transform _attackButtonContainer;

    public void Init(Unit player)
    {
        foreach (AttackData attack in player.Attacks)
        {
            AttackButton attackButton = Instantiate(_attackButtonPrefab, _attackButtonContainer);
            attackButton.Init(attack);
            attackButton.OnClick += _inputs.Attack;
        }
    }
}
