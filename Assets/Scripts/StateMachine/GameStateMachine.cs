using UnityEngine;

public class GameStateMachine : StateMachine
{
    [field: SerializeField] public Inputs Inputs { get; private set; }

    public Unit Player { get; private set; }
    public Unit Enemy { get; private set; }

    public void Init(Unit player, Unit enemy)
    {
        Player = player;
        Enemy = enemy;

        if (Player.GetStat(StatType.SPEED) >= Enemy.GetStat(StatType.SPEED))
        {
            SwitchState(new GamePlayerTurnState(this));
        }
        else
        {
            SwitchState(new GameEnemyTurnState(this));
        }
    }
}
