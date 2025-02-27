using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator anim;
    public PlayerMotor controller;

    public string horizontal = "X";
    public string vertical = "Z";

    public float damping = 0.05f;

    public string isMoving = "IsMoving";
    public float movingThreshold = .05f;

    public void Jump()
    {
        // anim.SetTrigger("Jump");
        // anim.Play("Jump", 1, 0f);
    }


    void Update()
    {
        var localized = controller.NormalizedInputMoveDirection;

        anim.SetBool("IsMoving", (localized.x != 0) || localized.z != 0);

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