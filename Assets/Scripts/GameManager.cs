using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IGameState _currentState;
    public bool HasPhaseEnd;
    /*public enum State
    {
        NewTurnPhase
        DrawPhase,
        ReadyPhase,
        MovePhase,
        AttackPhase,
        ResultPhase,
        EndPhase
    }*/
    public void ChangeState(IGameState newState)
    {
        HasPhaseEnd = false;
        _currentState?.ExitState(this);
        _currentState = newState;
        _currentState.EnterState(this);
    }
    private void Start()
    {
        HasPhaseEnd = false;
        ChangeState(new NewTurnPhase());
    }
    private void Update()
    {
        _currentState?.UpdateState(this);
        if (Input.GetKeyDown(KeyCode.K))
        {
            HasPhaseEnd = true;
        }
    }
}
