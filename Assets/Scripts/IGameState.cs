public interface IGameState
{
    public void EnterState(DuelManager duelManager);  //進入狀態時
    public void UpdateState(DuelManager duelManager); //持續狀態時
    public void ExitState(DuelManager duelManager);   //離開狀態時

}
