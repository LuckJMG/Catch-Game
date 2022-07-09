using UnityEngine;

namespace CatchGame
{
    public class SpawnerManager : MonoBehaviour
    {
        private IPrefabSpawner _prefabSpawner;

        private void Awake()
        {
            _prefabSpawner = GetComponent<IPrefabSpawner>();
        }

        private void Start()
        {
            _prefabSpawner.SpawnerInitialization();
        }
    }
}
