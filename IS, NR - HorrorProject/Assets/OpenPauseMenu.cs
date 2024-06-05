using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour
{

    public GameObject PauseMenu;

    [SerializeField] MouseLook MouseLookScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Open();
        }
    }

    private void Open()
    {
        PauseMenu.SetActive(true);

        Cursor.lockState = CursorLockMode.Confined;

        MouseLookScript.enabled = false;
    }


}
