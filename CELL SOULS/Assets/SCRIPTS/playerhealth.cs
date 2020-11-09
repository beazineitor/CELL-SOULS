using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public int maxHealth = 1000;
    public int currentHealth;
    public BarraDeSalud healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(250);
        }

        if (currentHealth==0)
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
            
        }
        if (currentHealth == 0)
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
