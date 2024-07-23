using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    public Animator PlayerAnimator;
    public float Elapsed;
    public bool FramePassed;

    Vector3 previousFramePosition;
    float MoveMentPerFrame;
    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    void CheckIfMoving()
    {
        if (MoveMentPerFrame >= 0.3f)
        {
            PlayerAnimator.SetBool("Moving", true);
            PlayerAnimator.SetBool("Idle", false);
            PlayerAnimator.SetBool("Sprinting", false);
        }
    }

    void CheckIfIdle()
    {
        if (MoveMentPerFrame < 0.3f)
        {
            PlayerAnimator.SetBool("Moving", false);
            PlayerAnimator.SetBool("Idle", true);
            PlayerAnimator.SetBool("Sprinting", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Elapsed += Time.deltaTime;
        if (Elapsed >= 0.3f)
        {
            Elapsed -= 0.3f;
            previousFramePosition = transform.position;
            FramePassed = true;
        }

        MoveMentPerFrame = Vector3.Distance(previousFramePosition, transform.position);
        if (MoveMentPerFrame >= 0.3f)
        {
            Invoke("CheckIfMoving", 1);
        }
        else if (MoveMentPerFrame < 0.3f)
        {
            Invoke("CheckIfIdle", 1);
        }

    }
}
