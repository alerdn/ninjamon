using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlefield : MonoBehaviour
{
    [field: SerializeField] public ControlsUI Controls { get; private set; }
    [field: SerializeField] public Unit Player { get; private set; }
    [field: SerializeField] public Unit Enemy { get; private set; }

    [SerializeField] private GameStateMachine _gameStateMachine;

    private void Start()
    {
        Controls.Init(Player);
        _gameStateMachine.Init(Player, Enemy);
    }
}
