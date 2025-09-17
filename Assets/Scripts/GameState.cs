using UnityEngine;

public class NewTurnPhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //�i�J���A��
    {
        Debug.Log("�^�X�}�l");
    }
    public void UpdateState(DuelManager duelManager)   //���򪬺A��
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new DrawPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        
    }
}
public class DrawPhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //�i�J���A��
    {
        Debug.Log("�i�J��P���q");
    }
    public void UpdateState(DuelManager duelManager)   //���򪬺A��
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new ReadyPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        Debug.Log("���}��P���q");
    }
}
public class ReadyPhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //�i�J���A��
    {
        Debug.Log("�i�J�ǳƶ��q");
    }
    public void UpdateState(DuelManager duelManager)   //���򪬺A��
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new MovePhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        Debug.Log("���}�ǳƶ��q");
    }
}
public class MovePhase : IGameState
{
    public void EnterState(DuelManager duelManager)    //�i�J���A��
    {
        Debug.Log("�i�J���ʶ��q");
    }
    public void UpdateState(DuelManager duelManager)   //���򪬺A��
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new AttackPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        Debug.Log("���}���ʶ��q");
    }
}
public class AttackPhase : IGameState
{
    public void EnterState(DuelManager duelManager)
    {
        Debug.Log("�i�J�X�P���q");
    }
    public void UpdateState(DuelManager duelManager)
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new ResultPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        Debug.Log("���}�X�P���q");
    }
}
public class ResultPhase : IGameState
{
    public void EnterState(DuelManager duelManager)
    {
        Debug.Log("�}�l����");
    }
    public void UpdateState(DuelManager duelManager)
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new EndPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        Debug.Log("���⧹��");
    }
}
public class EndPhase : IGameState
{
    public void EnterState(DuelManager duelManager)
    {
        Debug.Log("�i�J�������q");
    }
    public void UpdateState(DuelManager duelManager)
    {
        if (duelManager.HasPhaseEnd == true)
        {
            duelManager.ChangeState(new NewTurnPhase());
        }
    }
    public void ExitState(DuelManager duelManager)     //���}���A�� 
    {
        Debug.Log("�i�J�s���^�X");
    }
}
