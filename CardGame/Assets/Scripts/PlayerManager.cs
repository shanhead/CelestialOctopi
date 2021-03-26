using Mirror;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : NetworkBehaviour
{
    public GameObject player1Hand;
    public GameObject player2Hand;
    public GameObject player1Field;
    public GameObject player2Field;
    public GameObject Card;

    public override void OnStartClient()
    {
        base.OnStartClient();

        player1Hand = GameObject.Find("Player1Hand");
        player2Hand = GameObject.Find("Player2Hand");
        player1Field = GameObject.Find("Player1Field");
        player2Field = GameObject.Find("Player2Field");
    }

    // instantiates and spawns cards into client environment, then calls display function
    [Command]
    public void CmdDrawCards()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject card = Instantiate(Card, new Vector2(0, 0), Quaternion.identity);
            NetworkServer.Spawn(card, connectionToClient);
            RpcDisplay(card, "drawn");
        }
    }

    // helper function that calls display function on cards played from hand. Will eventually do more
    public void Play(GameObject card)
    {
        RpcDisplay(card, "played");
    }

    // Displays target card depending on who controls it and whether it is to be drawn into 
    // the player's hand or played onto the field.
    [ClientRpc]
    void RpcDisplay(GameObject card, string status)
    {
        if (hasAuthority)
        {
            if (status == "drawn")
                card.transform.SetParent(player1Hand.transform, false);
            if (status == "played")
                card.transform.SetParent(player1Field.transform, false);
        }
        else
        {
            if (status == "drawn")
                card.transform.SetParent(player2Hand.transform, false);
            if (status == "played")
                card.transform.SetParent(player2Field.transform, false);
        }
    }
}
