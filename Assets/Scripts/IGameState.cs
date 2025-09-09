public interface IGameState
{
    public void EnterState(GameManager gameManager);  //進入狀態時
    public void UpdateState(GameManager gameManager); //持續狀態時
    public void ExitState(GameManager gameManager);   //離開狀態時

}
