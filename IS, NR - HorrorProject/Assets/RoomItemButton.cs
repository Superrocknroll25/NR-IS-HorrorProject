using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomItemButton : MonoBehaviour
{
    public string RoomName;
    private GameObject JoinGameScreen;

    private void Start()
    {
        JoinGameScreen = GameObject.Find("Join Game Screen");
    }

    public void OnButtonPressed()
    {
        RoomList.Instance.JoinRoomsByName(RoomName);

        JoinGameScreen.SetActive(false);
    }
}

