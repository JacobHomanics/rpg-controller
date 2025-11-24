using UnityEngine;

namespace JacobHomanics.Essentials.RPGController
{
    public class PlayerAnimator : MonoBehaviour
    {
        public Animator anim;
        public PlayerMotor controller;

        public float damping = 0.05f;

        public string horizontal = "X";
        public string vertical = "Z";

        public string jump = "Jump";
        public bool triggerBasedJump;

        public bool isUsingIsMoving;
        public string isMoving = "IsMoving";

        public bool isUsingIsGrounded;

        public void Jump()
        {
            if (triggerBasedJump)
                anim.SetTrigger(jump);
            else
                anim.Play(jump, 1, 0f);
        }


        void Update()
        {
            var localized = controller.NormalizedInputMoveDirection;

            if (isUsingIsGrounded)
                anim.SetBool("IsGrounded", controller.characterController.isGrounded);

            if (isUsingIsMoving)
                anim.SetBool(isMoving, localized.x != 0 || localized.z != 0);

            if (localized.x > 0)
            {
                anim.SetFloat(horizontal, 1f, damping, Time.deltaTime);
            }
            else if (localized.x < 0)
            {
                anim.SetFloat(horizontal, -1f, damping, Time.deltaTime);
            }
            else
            {
                anim.SetFloat(horizontal, 0f, damping, Time.deltaTime);
            }

            if (localized.z > 0)
            {
                anim.SetFloat(vertical, 1f, damping, Time.deltaTime);
            }
            else if (localized.z < 0)
            {
                anim.SetFloat(vertical, -1f, damping, Time.deltaTime);
            }
            else
            {
                anim.SetFloat(vertical, 0f, damping, Time.deltaTime);
            }
        }
    }
}