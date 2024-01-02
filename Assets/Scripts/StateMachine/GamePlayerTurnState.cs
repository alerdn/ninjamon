using UnityEngine;

public class GamePlayerTurnState : GameBaseState
{
    public GamePlayerTurnState(GameStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        Debug.Log("Esperando ação do player...");
        stateMachine.Inputs.OnAttack += OnAttack;
    }

    public override void Tick(float deltaTime)
    {

    }

    public override void Exit()
    {
        stateMachine.Inputs.OnAttack -= OnAttack;
    }

    private void OnAttack(AttackData attack)
    {
        stateMachine.SwitchState(new GamePlayerAttackingState(stateMachine, attack));
    }
}
