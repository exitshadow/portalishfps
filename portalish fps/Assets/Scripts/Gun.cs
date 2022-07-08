using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject lightPrefab;
    public Transform bulletOrigin;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) 
        {
            GameObject newBullet = Instantiate(bulletPrefab, bulletOrigin.position, bulletOrigin.rotation);
            GameObject newLight = Instantiate(lightPrefab, bulletOrigin.position, bulletOrigin.rotation);
            newBullet.GetComponent<Bullet>().playerTransform = player;
            newLight.GetComponent<LightTracker>().target = newBullet;
            Debug.Log("trigger");
        }
    }
}
