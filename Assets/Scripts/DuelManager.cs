using UnityEngine;
using UnityEngine.Events;

public class DuelManager : MonoBehaviour
{
    [Header("DuelInformation")]
    private int Turn; //回合數
    private string StateText; //階段文字
    private string InformationText; //訊息文字
    private bool showStateText; //顯示階段文字
    private  bool showInformationText; //顯示訊息文字
    private  bool BattleEnd; //戰鬥終了
    private  bool isPlayerWin; //是否為玩家勝利

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
