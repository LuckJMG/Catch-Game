using UnityEngine;
using UnityEngine.SceneManagement;

namespace CatchGame
{
    public class GameManager : MonoBehaviour
    {
        private bool _gameOver;

        private void Start()
        {
            PlayerManager.OnGameOver += () => _gameOver = true;
        }

        private void Update()
        {
            if (_gameOver && Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

        private void OnDestroy()
        {
            PlayerManager.OnGameOver -= () => _gameOver = true;
        }
    }
}
