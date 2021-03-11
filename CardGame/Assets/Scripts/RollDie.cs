using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDie : MonoBehaviour
{
    public void click()
    {
        System.Random rand = new System.Random();
        print("You rolled a " + (rand.Next() % 6 + 1) + "!");
    }
}
