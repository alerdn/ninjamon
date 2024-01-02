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
        int damage = CalculateDamage(stateMachine.Player.GetStat(StatType.STRENGTH), _attack.Power);
        Debug.Log($"Player used {_attack.Name} on {stateMachine.Enemy} and caused {damage} damage");
        stateMachine.Enemy.Damage(damage);

        yield return new WaitForSeconds(1f);

        if (stateMachine.Enemy.CurrentHP == 0)
        {
            Debug.Log("Batalha finalizada: o player venceu");
            stateMachine.SwitchState(new GameIdleState(stateMachine));
        }
        else
        {
            stateMachine.SwitchState(new GameEnemyTurnState(stateMachine));
        }
    }
}
