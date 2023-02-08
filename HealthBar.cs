using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthBar 
{
    int currentHealth;
    int currentMaxHealth;

    public int Health
    {
        get 
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
        }
    }

    public int MaxHealth
    {
        get 
        {
            return currentMaxHealth;
        }
        set
        {
            currentMaxHealth = value;
        }
    }

    public HealthBar(int health, int maxHealth)
    {
        currentHealth = health;
        currentMaxHealth = maxHealth;
    }

    public void DmgUnit(int damageAmount)
    {
        if(currentHealth > 0)
        {
            currentHealth -= damageAmount;
        }
    }

    public void HealUnit(int healAmount)
    {
        if(currentHealth < currentMaxHealth)
        {
            currentHealth += healAmount;
        }
        if(currentHealth > currentMaxHealth)
        {
            currentHealth = currentMaxHealth;
        }
    }

    
}
