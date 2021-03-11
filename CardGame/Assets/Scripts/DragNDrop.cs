using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private Vector2 startPosition;
    private GameObject dropZone;
    
    void Update()
    {
        if (isDragging)
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    public void startDrag()
    {
        isDragging = true;
        startPosition = transform.position;
    }

    // if card is dropped over valid zone, drop there. Else, defaults back to where the card started.
    public void endDrag()
    {
        isDragging = false;
        if (isOverDropZone)
            transform.SetParent(dropZone.transform, false);
        else
            transform.position = startPosition;
    }

    // when a card is dragged onto a valid drop zone, lock onto it.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    // when the card is dragged away from the drop zone and dropped, revert back to default position.
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }
}