using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI textCoinCount;
   [SerializeField] private CoinManager coinManager;
   [SerializeField] private GameObject panelLost;
   [SerializeField] Button buttonRestartGame;
   public void UpdateTextCoinCount(int newCount)
   {
      textCoinCount.text = newCount.ToString();
      
   }

   private void Start()
   {
      panelLost.SetActive(false);
      UpdateTextCoinCount(0);
      
      buttonRestartGame.onClick.AddListener(RestartGame);
   }

   public void GameOverPanelOn()
   {
      panelLost.SetActive(true);
   }

   void RestartGame()
   {
      
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      
      
   }
   
}
