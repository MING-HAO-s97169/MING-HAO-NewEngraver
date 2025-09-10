using UnityEngine;

public class NewTurnPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�^�X�}�l");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new DrawPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        
    }
}
public class DrawPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�i�J��P���q");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new ReadyPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        Debug.Log("���}��P���q");
    }
}
public class ReadyPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�i�J�ǳƶ��q");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new MovePhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        Debug.Log("���}�ǳƶ��q");
    }
}
public class MovePhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�i�J���ʶ��q");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new AttackPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        Debug.Log("���}���ʶ��q");
    }
}
public class AttackPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�i�J�X�P���q");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new ResultPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        Debug.Log("���}�X�P���q");
    }
}
public class ResultPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�}�l����");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new EndPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        Debug.Log("���⧹��");
    }
}
public class EndPhase : IGameState
{
    public void EnterState(GameManager gameManager)    //�i�J���A��
    {
        Debug.Log("�i�J�������q");
    }
    public void UpdateState(GameManager gameManager)   //���򪬺A��
    {
        if (gameManager.HasPhaseEnd == true)
        {
            gameManager.ChangeState(new NewTurnPhase());
        }
    }
    public void ExitState(GameManager gameManager)     //���}���A�� 
    {
        Debug.Log("�i�J�s���^�X");
    }
}
