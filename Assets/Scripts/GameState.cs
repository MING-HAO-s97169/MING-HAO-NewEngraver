using UnityEngine;

public class NewTurnPhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //進入狀態時
    {
        Debug.Log("回合開始");
    }
    public void UpdateState(DuelManager duelManager)   //持續狀態時
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new DrawPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        
    }
}
public class DrawPhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //進入狀態時
    {
        Debug.Log("進入抽牌階段");
    }
    public void UpdateState(DuelManager duelManager)   //持續狀態時
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new ReadyPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        Debug.Log("離開抽牌階段");
    }
}
public class ReadyPhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //進入狀態時
    {
        Debug.Log("進入準備階段");
    }
    public void UpdateState(DuelManager duelManager)   //持續狀態時
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new MovePhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        Debug.Log("離開準備階段");
    }
}
public class MovePhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //進入狀態時
    {
        Debug.Log("進入移動階段");
    }
    public void UpdateState(DuelManager duelManager)   //持續狀態時
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new AttackPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        Debug.Log("離開移動階段");
    }
}
public class AttackPhase : IGameState
{
    public void EnterState(DuelManager duelManager)
    {
        Debug.Log("進入出牌階段");
    }
    public void UpdateState(DuelManager duelManager)
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new ResultPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        Debug.Log("離開出牌階段");
    }
}
public class ResultPhase : IGameState
{
    public void EnterState(DuelManager duelManager)
    {
        Debug.Log("開始結算");
    }
    public void UpdateState(DuelManager duelManager)
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new EndPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        Debug.Log("結算完畢");
    }
}
public class EndPhase : IGameState
{
    public void EnterState(DuelManager duelManager)
    {
        Debug.Log("進入結束階段");
    }
    public void UpdateState(DuelManager duelManager)
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new NewTurnPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //離開狀態時 
    {
        Debug.Log("進入新的回合");
    }
}
