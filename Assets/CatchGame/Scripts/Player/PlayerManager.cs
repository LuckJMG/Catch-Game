using UnityEngine;
using System;

namespace CatchGame
{
    public class PlayerManager : MonoBehaviour
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
                OnGameOver?.Invoke();
                Destroy(gameObject);
            }
        }

        private void OnDestroy()
        {
            OnCoinTrigger = null;
        }
    }
}
