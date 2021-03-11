using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    void click()
    {
        System.Random rand = new System.Random();
        print(rand.Next() % 2 == 0 ? "You win!" : "You lose...");
    }
}
