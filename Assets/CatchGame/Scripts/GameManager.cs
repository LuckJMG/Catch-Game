using UnityEngine;
using UnityEngine.SceneManagement;

namespace CatchGame
{
    public class GameManager : MonoBehaviour
    {
        private bool _gameOver;

        private void Start()
        {
            CollisionManager.OnGameOver += () => _gameOver = true;
        }

        private void Update()
        {
            if (_gameOver && Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
