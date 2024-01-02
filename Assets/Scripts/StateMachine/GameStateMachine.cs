using UnityEngine;

public class GameStateMachine : StateMachine
{
    [field: SerializeField] public Inputs Inputs { get; private set; }

    private void Start()
    {
        SwitchState(new GamePlayerTurnState(this));
    }
}
