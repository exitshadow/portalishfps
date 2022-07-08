using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTracker : MonoBehaviour
{
    public GameObject target;


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = target.transform.position;

        if (target == null) {
            Destroy(gameObject);
            Debug.Log("light destroyed via target null");
        }
    }

}
