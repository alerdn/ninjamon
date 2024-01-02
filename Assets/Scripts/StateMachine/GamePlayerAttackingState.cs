using System.Collections;
using UnityEngine;

public class GamePlayerAttackingState : GameBaseState
{
    private AttackData _attack;

    public GamePlayerAttackingState(GameStateMachine stateMachine, AttackData attack) : base(stateMachine)
    {
        _attack = attack;
    }

    public override void Enter()
    {
        stateMachine.StartCoroutine(Attack(_attack));
    }

    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }

    private IEnumerator Attack(AttackData attack)
    {
        Debug.Log($"Player attacked with {_attack.Name}");
        yield return new WaitForSeconds(1f);
        stateMachine.SwitchState(new GamePlayerTurnState(stateMachine));
    }
}
