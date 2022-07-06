using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("A WINNER IS YOU!");
        }
    }
}
