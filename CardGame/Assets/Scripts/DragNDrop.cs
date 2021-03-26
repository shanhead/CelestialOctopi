using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : NetworkBehaviour
{
    public GameObject player1Field;
    public GameObject player2Field;
    public PlayerManager playerManager;
    
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private bool canDrag;
    private Vector2 startPosition;
    private GameObject dropZone;
    
    private void Start()
    {
        player1Field = GameObject.Find("Player1Field");
        player2Field = GameObject.Find("Player2Field");
        canDrag = hasAuthority;
    }
    
    void Update()
    {
        if (isDragging)
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    public void startDrag()
    {
        if (canDrag)
        {
            isDragging = true;
            startPosition = transform.position;
        }
        
    }

    // if card is dropped over valid zone, drop there. Else, defaults back to where the card started.
    public void endDrag()
    {
        if (canDrag)
        {
            isDragging = false;
            if (isOverDropZone)
            {
                transform.SetParent(dropZone.transform, false);
                canDrag = false;
                NetworkIdentity networkID = NetworkClient.connection.identity;
                playerManager = networkID.GetComponent<PlayerManager>();
                playerManager.Play(gameObject);
            }
            else
                transform.position = startPosition;

        }
    }

    // when a card is dragged onto a valid drop zone, lock onto it.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player1Field)
        {
            isOverDropZone = true;
            dropZone = collision.gameObject;
        }
    }

    // when the card is dragged away from the drop zone and dropped, revert back to default position.
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }
}