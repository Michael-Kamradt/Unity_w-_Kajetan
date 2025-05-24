using UnityEngine;

public class CoinManager : MonoBehaviour

{
    [SerializeField] public int coinCounter = 0;
    [SerializeField] public UIManager uiManager;

    public void AddCoin()
    {
        coinCounter++;
        Debug.Log(coinCounter);
        uiManager.UpdateTextCoinCount(coinCounter);
        
    }
}
