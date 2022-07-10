using TMPro;
using UnityEngine;

namespace CatchGame
{
    public class CoinCountManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI coinTextMesh;
        public static int CoinCount;

        private void Start()
        {
            CoinCount = 0;
            PlayerManager.OnCoinTrigger += OnCountUpdate;
            PlayerManager.OnGameOver += OnGameOver;
        }

        private void OnDestroy()
        {
            PlayerManager.OnCoinTrigger -= OnCountUpdate;
            PlayerManager.OnGameOver -= OnGameOver;
        }

        private void OnGameOver()
        {
            coinTextMesh.gameObject.SetActive(false);
        }

        private void OnCountUpdate()
        {
            CoinCount += 1;
            if (coinTextMesh != null) coinTextMesh.text = "Coins: " + CoinCount.ToString();
        }
    }
}
