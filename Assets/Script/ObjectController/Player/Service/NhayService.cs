using UnityEngine;
using static StateConstant;

namespace Assets.Script.ObjectController.Player
{
    public class NhayService
    {

        private readonly Rigidbody2D rb;
        private readonly Transform groundCheck;
        private Animator animator;


        private readonly float jumpForce;
        private readonly LayerMask groundLayer;

        private float jumpBufferTime = 0.15f;
        private float jumpBufferCounter;
        private readonly float fallMultiplier;
        private readonly float lowJumpMultiplier;

        private bool isHoldingJump;

        public NhayService(
            Animator animator,
            Rigidbody2D rb,
            Transform groundCheck,
            LayerMask groundLayer,
            float jumpForce,
            float fallMultiplier,
            float lowJumpMultiplier
            )
        {
            this.animator = animator;
            this.rb = rb;
            this.groundCheck = groundCheck;
            this.groundLayer = groundLayer;
            this.jumpForce = jumpForce;
            this.fallMultiplier = fallMultiplier;
            this.lowJumpMultiplier = lowJumpMultiplier;
        }

        public void HandleInput(bool jumpPressed, bool holdingJump)
        {
            if (jumpPressed)
            {
                animator.SetInteger(STATE_HASH, StateAnimation.JUMP);
                jumpBufferCounter = jumpBufferTime;
            }

            isHoldingJump = holdingJump;
        }

        public void FixedJump()
        {
            jumpBufferCounter -= Time.fixedDeltaTime;

            if (jumpBufferCounter > 0 && IsGrounded())
            {
                rb.linearVelocity =
                    new Vector2(rb.linearVelocity.x, jumpForce);

                jumpBufferCounter = 0;
            }

            HandleBetterJump();
        }
        private void HandleBetterJump()
        {
            // Falling
            if (rb.linearVelocity.y < 0)
            {
                rb.gravityScale = fallMultiplier;
            }
            // Going up but released jump
            else if (rb.linearVelocity.y > 0 && !isHoldingJump)
            {
                rb.gravityScale = lowJumpMultiplier;
            }
            else
            {
                rb.gravityScale = 3f;
            }
        }
        private bool IsGrounded()
        {
            return Physics2D.OverlapCircle(
                groundCheck.position,
                0.2f,
                groundLayer
            );
        }
    }
}