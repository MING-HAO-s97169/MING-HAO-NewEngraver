using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IGameState _currentState;
    /*public enum State
    {
        DrawPhase,
        ReadyPhase,
        MovePhase,
        AttackPhase,
        ResultPhase,
        EndPhase
    }*/
    public void ChangeState(IGameState newState)
    {
        _currentState?.ExitState(this);
        _currentState = newState;
        _currentState.EnterState(this);
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        _currentState?.UpdateState(this);
    }
    public bool HasPhaseEnd()
    {
        return true;
    }
}
