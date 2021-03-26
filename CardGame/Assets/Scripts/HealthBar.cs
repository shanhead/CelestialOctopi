using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthBar : MonoBehaviour 
{

    public Slider slider;
	
        public void setMaxHealth(int health)
        {
        slider.maxValue = health;
        slider.Value = health;
        } //end MaxHealth 
 
        public void setHealth (int health)
        {
            slider.value = health;
        } //end setHealth	
} //end class
