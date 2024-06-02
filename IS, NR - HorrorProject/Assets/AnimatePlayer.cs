using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    public Rigidbody rb;
    public Animation animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity == Vector3.zero)
        {
            animator.Stop();
        }
        if (rb.velocity != Vector3.zero)
        {
            animator.Play();
        }
    }
}
