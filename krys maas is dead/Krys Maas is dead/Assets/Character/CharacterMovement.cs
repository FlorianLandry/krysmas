
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float walkSpeed = 2;
    public float runSpeed = 6;
    public float gravity = -15;
    public float jumpHeight = 1;
    public float secondJumpHeight = 0.8f;
    public Stamina stamina;

    [Range(0, 1)]
    public float airControlPercent = 0.5f;

    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    public float speedSmoothTime = 0.1f;
    float speedSmoothVelocity;
    float currentSpeed;
    float velocityY;
    float groundDistance = 0.2f;
    bool isGrounded;
    bool secondJump;
    public LayerMask groundMask;

    Animator animator;
    Transform cameraT;
    CharacterController controller;
    public Transform groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cameraT = Camera.main.transform;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = input.normalized;
        bool running = Input.GetKey(KeyCode.LeftShift);

        Move(inputDir, running);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.F)) animator.SetTrigger("doEmote");

        float animSpeedPercent = (running) ? currentSpeed / runSpeed : currentSpeed / walkSpeed * .5f;
        animator.SetFloat("speedPercent", animSpeedPercent, speedSmoothTime, Time.deltaTime);
    }

    void Move(Vector2 inputDir, bool running)
    {
        if (inputDir != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, GetModifiedSmoothTime(turnSmoothTime));
        }


        float targetSpeed = ((running && !stamina.tired) ? runSpeed : walkSpeed) * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothTime, GetModifiedSmoothTime(speedSmoothVelocity));

        velocityY += Time.deltaTime * gravity;
        Vector3 velocity = transform.forward * currentSpeed + Vector3.up * velocityY;

        controller.Move(velocity * Time.deltaTime);
        currentSpeed = new Vector2(controller.velocity.x, controller.velocity.z).magnitude;

        if (velocityY > 0) isGrounded = false;

        if (isGrounded)
        {
            velocityY = -1f;
            animator.SetBool("isJumping", false);
            secondJump = true;
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            float jumpVelocity = Mathf.Sqrt(-2 * gravity * jumpHeight);
            velocityY = jumpVelocity;
            animator.SetBool("isJumping", true);
        }
        else if (secondJump)
        {
            float jumpVelocity = Mathf.Sqrt(-2 * gravity * secondJumpHeight);
            velocityY = jumpVelocity;
            secondJump = false;
        }
    }

    float GetModifiedSmoothTime(float smoothTime)
    {
        if (isGrounded) return smoothTime;
        if (airControlPercent == 0) return float.MaxValue;
        return smoothTime / airControlPercent;
    }
}
