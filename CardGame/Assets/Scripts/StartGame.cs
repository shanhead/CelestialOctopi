using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject playerHand;
    public GameObject enemyHand;
    public GameObject Card;

    void Start()
    {
        
    }

    public void click()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject uCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            uCard.transform.SetParent(playerHand.transform, false);

            GameObject eCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            eCard.transform.SetParent(enemyHand.transform, false);
        }
    }
}
