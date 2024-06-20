using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{

    public CharacterController cc;

    public AudioSource FootstepsAudio;

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && FootstepsAudio.isPlaying == false)
        {
            FootstepsAudio.Play();
        }
    }
}
