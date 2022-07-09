using TMPro;
using UnityEngine;

namespace CatchGame
{
    public class CoinCountManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI coinTextMesh;
        private int _coinCount;

        private void Start()
        {
            PlayerManager.OnCoinTrigger += OnCountUpdate;
        }

        private void OnDestroy()
        {
            PlayerManager.OnCoinTrigger -= OnCountUpdate;
        }

        private void OnCountUpdate()
        {
            _coinCount += 1;
            if (coinTextMesh != null) coinTextMesh.text = "Coins: " + _coinCount.ToString();
        }
    }
}
