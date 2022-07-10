using UnityEngine;
using TMPro;

namespace CatchGame
{
    public class GameOverManager : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverScreen;
        [SerializeField] private TextMeshProUGUI scoreText;
        private bool _gameOver;

        private void Start()
        {
            PlayerManager.OnGameOver += OnGameOver;
        }

        private void OnGameOver()
        {
            gameOverScreen.SetActive(true);
            scoreText.text = "Score: " + CoinCountManager.CoinCount.ToString();
        }
    }
}
