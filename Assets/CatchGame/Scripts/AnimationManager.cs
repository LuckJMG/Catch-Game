using UnityEngine;

namespace CatchGame
{
    public class AnimationManager : MonoBehaviour
    {
        private InputHandler _inputHandler;
        private Transform _transform;
        private Vector2 _input;

        private void Awake()
        {
            _inputHandler = GetComponent<InputHandler>();
            _transform = transform;
        }

        private void Update()
        {
            if (_inputHandler != null) _input = _inputHandler.PlayerInput;
            Flip();
        }

        private void Flip()
        {
            if (_input.x != 0) _transform.localScale = new Vector2(_input.x, 1);
        }
    }
}
