using UnityEngine;

namespace CatchGame
{
    public class InputHandler : MonoBehaviour
    {
        private Vector2 _playerInput;

        public Vector2 PlayerInput { get => _playerInput; }

        private void Update()
        {
            _playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        }
    }
}
