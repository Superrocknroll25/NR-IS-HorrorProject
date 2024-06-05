using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviourPunCallbacks
{
    private ConnecterOfPreFabToScene PlayerPrefabConnecter;

    [SerializeField] Slider Slider;

    [SerializeField] MouseLook MouseLookScript;

    private void Start()
    {
        PlayerPrefabConnecter = GameObject.Find("PlayerPrefabConnecterToLobby").GetComponent<ConnecterOfPreFabToScene>();
    }

    public void LeaveGame()
    {
        PlayerPrefabConnecter.EnableLobby();

        PhotonNetwork.LeaveRoom();
    }

    public void UnLock()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SliderValueChange()
    {
        MouseLookScript.mouseSensitivity = Slider.value;
    }
}