using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerHealingState : GameBaseState
{
    public GamePlayerHealingState(GameStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.StartCoroutine(Heal());
    }

    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }

    private IEnumerator Heal()
    {
        Debug.Log("Player curando em 50");
        stateMachine.Player.Heal(50);

        yield return new WaitForSeconds(1f);

        stateMachine.SwitchState(new GameEnemyTurnState(stateMachine));
    }
}
