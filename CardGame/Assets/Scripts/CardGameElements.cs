using System.Collection;
using System.Collections.Generic;
using UnityEngine;

public class CardGameElements : MonoBehavior
 {
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerZone;
    public GameObject EnemyZone;
    
    void Start() {
    cards.append(Card1);
    cards.append(Card2);
    }
    
    public void Click() {
          for (int i = 0; i < 5; i++) {
          
          GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector(0, 0, 0), Quaternion.identity);
          playerCard.transform.SetParent(PlayerArea.transform, false);
          
          GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector(0, 0, 0), Quaternion.identity);
          playerCard.transform.SetParent(PlayerArea.transform, false);
          }
}
