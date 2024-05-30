using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject player;

    [Space]
    public Transform spawnPoint;

    public string roomNameToJoin = "test";

    // Start is called before the first frame update

    private void Start()
    {
        Debug.Log("Connectijg");

        PhotonNetwork.JoinOrCreateRoom(roomNameToJoin, null, null);
    }



    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Debug.Log("Him number 2");

        GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity);
        _player.GetComponent<PlayerSetup>().IsLocalPlayer();
    }
}
