using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    // public float x;

    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);
        rb.AddForce(transform.up * force / 10);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Illegal")
        // if (collision.collider.CompareTag("Illegal")) // method that is less resource consuming
        {
            playerTransform.position = collision.GetContact(0).point;
            Destroy(gameObject);
        } else Debug.Log("That’s ILLEEEEEEEEGAL!!!!");
    }

}
