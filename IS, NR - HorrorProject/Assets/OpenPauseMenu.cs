using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour
{

    public GameObject PauseMenu;

    [SerializeField] MouseLook MouseLookScript;


    public PlayerSetup ps;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Open();
        }
    }

    private void Open()
    {
        //if (ps.PauseMenuIsLocal)
        //{
            PauseMenu.SetActive(true);

            Cursor.lockState = CursorLockMode.Confined;

            MouseLookScript.enabled = false;
        //}
    }


}
