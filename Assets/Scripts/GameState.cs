using UnityEngine;

public class NewTurnPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("回合開始");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new DrawPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        
    }
}
public class DrawPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("進入抽牌階段");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new ReadyPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        Debug.Log("離開抽牌階段");
    }
}
public class ReadyPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("進入準備階段");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new MovePhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        Debug.Log("離開準備階段");
    }
}
public class MovePhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("進入移動階段");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new AttackPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        Debug.Log("離開移動階段");
    }
}
public class AttackPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("進入出牌階段");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new ResultPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        Debug.Log("離開出牌階段");
    }
}
public class ResultPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("開始結算");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new EndPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        Debug.Log("結算完畢");
    }
}
public class EndPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //進入狀態時
    {
        Debug.Log("進入結束階段");
    }
    public void UpdateState(GameManager gameManager)   //持續狀態時
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new NewTurnPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //離開狀態時 
    {
        Debug.Log("進入新的回合");
    }
}
