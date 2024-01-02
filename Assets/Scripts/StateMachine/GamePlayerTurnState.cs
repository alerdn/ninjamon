using UnityEngine;

public class GamePlayerTurnState : GameBaseState
{
    public GamePlayerTurnState(GameStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        stateMachine.Inputs.OnAttack += OnAttack;
        stateMachine.Inputs.OnHeal += OnHeal;

        Debug.Log("Esperando ação do player...");
        ScreenManager.Instance.Show(ScreenType.ACTIONS);
    }

    public override void Tick(float deltaTime)
    {

    }

    public override void Exit()
    {
        ScreenManager.Instance.Show(ScreenType.NONE);

        stateMachine.Inputs.OnAttack -= OnAttack;
        stateMachine.Inputs.OnHeal -= OnHeal;
    }

    private void OnAttack(AttackData attack)
    {
        stateMachine.SwitchState(new GamePlayerAttackingState(stateMachine, attack));
    }

    private void OnHeal()
    {
        stateMachine.SwitchState(new GamePlayerHealingState(stateMachine));
    }
}
