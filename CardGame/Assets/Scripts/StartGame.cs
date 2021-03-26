using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : NetworkBehaviour
{
    public PlayerManager PlayerManager;
    

    public void click()
    {
        NetworkIdentity networkID = NetworkClient.connection.identity;
        PlayerManager = networkID.GetComponent<PlayerManager>();
        PlayerManager.CmdDrawCards();
    }
}
