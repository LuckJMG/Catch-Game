using UnityEngine;
using System;

namespace CatchGame
{
    public class PlayerManager : MonoBehaviour
    {
        private static Action OnCoinTrigger;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                Destroy(other.gameObject);
                OnCoinTrigger?.Invoke();
            }
        }

        private void OnDestroy()
        {
            OnCoinTrigger = null;
        }
    }
}
