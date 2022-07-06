using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletOrigin;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) {
            GameObject newBullet = Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
            newBullet.GetComponent<Bullet>().playerTransform = player;
            Debug.Log("trigger");
        }
    }
}
