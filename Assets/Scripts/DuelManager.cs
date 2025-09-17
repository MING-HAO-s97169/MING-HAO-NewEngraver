using UnityEngine;
using UnityEngine.Events;

public class DuelManager : MonoBehaviour
{
    [Header("DuelInformation")]
    private int Turn; //�^�X��
    private string StateText; //���q��r
    private string InformationText; //�T����r
    private bool showStateText; //��ܶ��q��r
    private  bool showInformationText; //��ܰT����r
    private  bool BattleEnd; //�԰��פF
    private  bool isPlayerWin; //�O�_�����a�ӧQ

    [Header("GameStateController")]
    private IGameState _currentState;
    public bool HasPhaseEnd;
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
