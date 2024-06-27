using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12;
    public float gravity = -9.81f;
    public float Jumpheight = 3f;

    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask GroundMask;

    Vector3 velocity;
    bool isGrounded;

    public float HorizontalSpeed;

    public Animator animator;
    public float Elapsed;

    Vector3 previousFramePosition;

    void Update()
    {
       
            isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, GroundMask);
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

        

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;


            }



            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(Jumpheight * -2 * gravity);

            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

        Elapsed = Time.deltaTime;

        if(Elapsed >= 1.0f)
        {
            Elapsed = 0;
            previousFramePosition = transform.position;
        }

        float movementPerFrame = Vector3.Distance(previousFramePosition, transform.position);

        if (transform.position != previousFramePosition)
        {
            Debug.Log("Moving");
            animator.SetBool("Moving", true);
            animator.SetBool("Idle", false);
        } else if(transform.position == previousFramePosition)
        {
            Debug.Log("Idle");
            animator.SetBool("Moving", false);
            animator.SetBool("Idle", true);
        }
        
        }
    }

