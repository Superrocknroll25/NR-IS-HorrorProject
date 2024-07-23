using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        
        }
    }

