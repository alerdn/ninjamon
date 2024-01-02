using UnityEngine;

public abstract class GameBaseState : State
{
    protected GameStateMachine stateMachine;

    public GameBaseState(GameStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public int CalculateDamage(float strength, float power)
    {
        return Mathf.RoundToInt(strength * (power / 100f));
    }
}
