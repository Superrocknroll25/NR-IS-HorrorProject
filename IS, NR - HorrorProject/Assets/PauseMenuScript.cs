using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PauseMenuScript : MonoBehaviour
{

    public void LeaveGame()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void UnLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}