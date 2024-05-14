using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MouseLook : MonoBehaviour

{


    public float mouseSensitivity = 100f;

    public Transform PlayerBody;

    float xRotation = 0f;

   public PhotonView view1;
    // Start is called before the first frame update
    void Start()
    {
        

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (view1.IsMine)
        {

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


            PlayerBody.Rotate(Vector3.up * mouseX);

        }
    }
}