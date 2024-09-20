using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 1.0f; // Time between spawns in seconds
    private float nextSpawnTime = 0f;  // Time when the player can spawn the next dog

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if cooldown has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawnTime)
        {
            // Spawn dog
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            // Set the next spawn time
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }
}
