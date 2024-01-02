public abstract class GameBaseState : State
{
    protected GameStateMachine stateMachine;

    public GameBaseState(GameStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
}
