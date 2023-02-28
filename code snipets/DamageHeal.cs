using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHeal : MonoBehaviour
{
    public float currentHealth;
    public float damage = 10.0f;
    public float maxHealth = 100.0f;

    void Start()
    {
        currentHealth = maxHealth;
        GameManager.instance.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown("backspace"))
        {
            TakeDamage(damage);
        }
        else if (Input.GetKeyDown("space"))
        {
            Heal(damage);
        }
    }

    public void TakeDamage(float damage)
    {
        if (currentHealth == 0)
        {
            return;
        }
        currentHealth -= damage;
        GameManager.instance.SetHealth(currentHealth);
    }

    public void Heal(float damage)
    {
        if (currentHealth == 100)
        {
            return;
        }
        currentHealth += damage;
        GameManager.instance.SetHealth(currentHealth);
    }
}
