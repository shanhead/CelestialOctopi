using System;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotal : MonoBehaviour {

    public int health;
    public int healthCounter = 20;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        if (health > healthCounter)
        {
            health = healthCounter;
        }

        for (int i = 0; i < hearts.Length; i++)
        {

            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            } //end else
            else
            {
                hearts[i];
            } //end else

            if (i < healthCounter)
            {
                hearts[i].enabled = true;
            } //end if
            else
            {
                hearts[i].enabled = false;
            } //end else
        } //end for loop
    } //end UpdateHealth method
} //end LifeTotal class
