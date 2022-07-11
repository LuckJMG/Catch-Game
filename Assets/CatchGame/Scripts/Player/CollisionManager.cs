using UnityEngine;
using System;

namespace CatchGame
{
    public class CollisionManager : MonoBehaviour
    {
        public static Action OnCoinTrigger;
        public static Action OnGameOver;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                Destroy(other.gameObject);
                OnCoinTrigger?.Invoke();
            }
            if (other.gameObject.CompareTag("Spike"))
            {
                gameObject.SetActive(false);
                OnGameOver?.Invoke();
            }
        }

        private void OnDestroy()
        {
            OnCoinTrigger = null;
            OnGameOver = null;
        }
    }
}
