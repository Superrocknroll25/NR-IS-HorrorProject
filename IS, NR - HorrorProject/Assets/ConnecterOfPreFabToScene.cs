using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnecterOfPreFabToScene : MonoBehaviour
{
    public GameObject LobbyForEnablement;

    public void EnableLobby()
    {
        LobbyForEnablement.SetActive(true);
    }
}
