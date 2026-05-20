using UnityEngine;
using static StateConstant;

namespace Assets.Script.ObjectController.MainCharactor
{
    public class DiChuyenService
    {
        private Rigidbody2D rigidbody2D;
        private Animator animator;
        private Transform transform;
        private float moveX; 
        private readonly float speed;
        public DiChuyenService(Rigidbody2D rigidbody2D, Animator animator, Transform transform, float speed)
        {
            this.rigidbody2D = rigidbody2D;
            this.animator = animator;
            this.transform = transform;
            this.speed = speed;
        }

        public void HandleInput(float moveX)
        {
            this.moveX = moveX;
            if (moveX == 0)
            {
                animator.SetInteger(STATE_HASH, StateAnimation.IDLE);
            }
            if (moveX > 0)
            {
                animator.SetInteger(STATE_HASH, StateAnimation.RUN);
                transform.localScale = StateConstant.FACE_RIGHT;
            }

            if (moveX < 0)
            {
                animator.SetInteger(STATE_HASH, StateAnimation.RUN);
                transform.localScale = StateConstant.FACE_LEFT;
            }

        }
        public void FixedMove()
        {
            rigidbody2D.linearVelocity =
                new Vector2(moveX * speed,
                rigidbody2D.linearVelocity.y);
        }

    }
}