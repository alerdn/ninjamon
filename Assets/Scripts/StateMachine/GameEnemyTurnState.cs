using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnemyTurnState : GameBaseState
{
    public GameEnemyTurnState(GameStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        AttackData attack = stateMachine.Enemy.Attacks.GetRandom();
        stateMachine.SwitchState(new GameEnemyAttackingState(stateMachine, attack));
    }

    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }
}
