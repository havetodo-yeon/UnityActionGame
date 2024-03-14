using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    GameObject player;
    PlayerHealth playerHealth;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            Debug.Log("HEAL!!!!!!");
            PlayerHeal();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
    }

    private void PlayerHeal()
    {
        playerHealth.currentHealth = playerHealth.startingHealth;
        playerHealth.healthSlider.value = playerHealth.currentHealth;
    }
}
