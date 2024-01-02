using System.Collections;
using UnityEngine;

public class GameEnemyAttackingState : GameBaseState
{
    private AttackData _attack;

    public GameEnemyAttackingState(GameStateMachine stateMachine, AttackData attack) : base(stateMachine)
    {
        _attack = attack;
    }

    public override void Enter()
    {
        stateMachine.StartCoroutine(Attack());
    }

    public override void Tick(float deltaTime)
    {
    }

    public override void Exit()
    {
    }

    private IEnumerator Attack()
    {
        Debug.Log($"Enemy used {_attack.Name} on {stateMachine.Player}");

        int damage = CalculateDamage(stateMachine.Enemy.GetStat(StatType.STRENGTH), _attack.Power);
        stateMachine.Player.Damage(damage);

        yield return new WaitForSeconds(1f);
        if (stateMachine.Player.CurrentHP == 0)
        {
            Debug.Log("Batalha finalizada: o inimigo venceu");
            stateMachine.SwitchState(new GameIdleState(stateMachine));
        }
        else
        {
            stateMachine.SwitchState(new GamePlayerTurnState(stateMachine));
        }
    }
}
