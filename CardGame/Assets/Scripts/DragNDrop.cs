using System.Collection;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{

   private bool isDragging = false;
   private bool isOverDropZone = false;
   private GameObject : dropZone;
   private Vector2 startPosition;
   
   void Update() {
     if (isDragging) {
      
        transform.position = new Vector2(Input, mousePosition.x, Input mousePosition.y);
   } 
        
        private void onCollision2D(Collision 2D) {
           isOverDropZone = true;
           dropZone = collision.gameObject;
       }

          public void StartDrag() {
             startPosition = transform.position;
             isDragging = true;
          }

          public void EndDrag() {
              isDragging = false;
              if(isOverDropZone) {

                 transform.SetParent(dropZone,transform, false);
              }
              else {
                 transform.position = startPosition;
              }
        }
}
    
