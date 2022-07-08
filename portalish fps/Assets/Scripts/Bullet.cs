using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    private float yBeforeCollision;
    private float yAfterCollision;
    private bool isTeleportable;

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
        yBeforeCollision = gameObject.transform.position.y;

        // if (collision.collider.CompareTag("Illegal")) // method that is less resource consuming
        if (collision.collider.tag == "Legal") {
            if (Vector3.Angle(collision.GetContact(0).normal, Vector3.up) <= 65) {

                playerTransform.position = collision.GetContact(0).point;
                Destroy(gameObject);
            }
            // pass light and child to destroy it here
        }
        
        if (collision.collider.tag == "SuperBounce") {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        } else {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

}
