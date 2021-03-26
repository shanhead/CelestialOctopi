using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotal : MonoBehaviour {

    public static int maxHealth = 20;
    public static int currHealth;

    void Start() 
    {
        currHealth = maxHealth;
    }

    void Update()
    {
        TakeDamage(1);
    } //end Update

     void TakeDamage (int damageAmount) {
        currHealth = damageAmount - currHealth;

       } //end TakeDamage
  } //end class
    
      
