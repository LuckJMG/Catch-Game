using UnityEngine;

namespace CatchGame
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        private InputHandler _inputHandler;
        private Rigidbody2D _rigidbody;
        private Vector2 _input;

        private void Awake()
        {
            _inputHandler = GetComponent<InputHandler>();
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (_inputHandler != null) _input = _inputHandler.PlayerInput;
            HorizontalMovement();
        }

        private void HorizontalMovement()
        {
            if (_rigidbody != null) _rigidbody.velocity = _input * speed;
        }
    }
}
