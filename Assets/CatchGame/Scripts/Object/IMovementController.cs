using UnityEngine;

namespace CatchGame
{
    public interface IMovementController
    {
        public void MoveTowardsDirection(Vector3 direction, float speed);
    }
}
