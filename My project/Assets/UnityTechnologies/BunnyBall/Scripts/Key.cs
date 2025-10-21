using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // This is a variable for the shackwave Prefab
    [SerializeField] GameObject shockwavePrefab;
    // This is a variable for the game manager
    [SerializeField] GameManager gameManager;

    // This function runs once at the beginning of the game
    private void Start()
    {
        // Finds the gameManager
        gameManager = FindObjectOfType<GameManager>();
    }

    // This function runs when we collide with the trigger
    private void OnTriggerEnter(Collider other)
    {
        // checks if we collide with the player 
        if (other.CompareTag("Player")) {
            // sets game over to true
            gameManager.gameOver = true;
            //creates a shockwave 
            Instantiate(shockwavePrefab, transform.position, Quaternion.identity);
            // destroys key 
            Destroy(gameObject, 0.1f);
        }
    }
}
 