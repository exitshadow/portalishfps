using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rb;
    [Range(0.0f, 10.0f)] public float force = 1f;
    [Range(0.0f, 0.25f)] public float forceIncrement = 0.125f;

    public float spawnInterval = 3f;
    private float timer;

    void Start()
    {
        timer = spawnInterval;
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.up * force); // un peu mieux de ne pas faire un new Vector3, question mémoire
    }

    
    // Ceci fonctionne à la vitesse d’affichage
    void Update()
    {
        // À chaque fois que l’objet est immobile, ajouter une force
        // via Rigidbody.velocity
        // == > et on va le mettre dans FixedUpdate();

        timer -= Time.deltaTime;
        if (timer <= 0) {
            timer = spawnInterval;
            Instantiate(gameObject, transform.position, Quaternion.identity);
        }

    }

    // Ceci fonctionne à 60FPS fixe
    // aide à avoir un comportement linéaire et prévisible
    void FixedUpdate()
    {
        if(rb.IsSleeping())
        {
            rb.AddForce(Vector3.up * force);
            force += forceIncrement;
        }
    }
}
