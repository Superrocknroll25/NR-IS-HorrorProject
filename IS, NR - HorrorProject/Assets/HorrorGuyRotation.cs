using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorGuyRotation : MonoBehaviour
{
    public Transform MainRotation;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = MainRotation.rotation;
    }
}
