public interface IGameState
{
    public void EnterState(DuelManager duelManager);  //�i�J���A��
    public void UpdateState(DuelManager duelManager); //���򪬺A��
    public void ExitState(DuelManager duelManager);   //���}���A��

}
