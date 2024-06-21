using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public PlayerMovement movement;

    public GameObject camera;

    public bool PauseMenuLocal = false;

    public GameObject InventoryUI;

    public void IsLocalPlayer()
    {
        movement.enabled = true;

        camera.SetActive(true);

        PauseMenuLocal = true;

        InventoryUI.SetActive(true);
    }

}
