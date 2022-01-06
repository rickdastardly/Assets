using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Vairables
    public float maxHealth, maxThirst, maxHunger;
    public float thirstDecreaseRate, hungerDecreaseRate, healthDecreaseRate;
    public float health, thirst, hunger;

    public bool dead;

    //Functions
    public void Start()
    {
        health = maxHealth;
    }


    public void Update()
    {
        //Thirst and hunger decrease over time
        if (!dead)
        {
            thirst += thirstDecreaseRate * Time.deltaTime;
            hunger += hungerDecreaseRate * Time.deltaTime;
        }



        if (thirst >= maxThirst)
        {
            Die();
        }


        if (hunger >= maxHunger)
        {
            Die();
        }
    }

    public void Die()
    {
        dead = true;
        print("Player has died.");
    }
}