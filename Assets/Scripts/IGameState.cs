public interface IGameState
{
    public void EnterState(GameManager gameManager);  //�i�J���A��
    public void UpdateState(GameManager gameManager); //���򪬺A��
    public void ExitState(GameManager gameManager);   //���}���A��

}
