using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{

    public string targetLevel;

    void OnTriggerEnter(Collider other) {

        Debug.Log("OnTriggerEnter is triggered.");
        
        if (other.tag == "Player") {
            Debug.Log("A WINNER IS YOU!");
            SceneManager.LoadScene(targetLevel);
        }

        if (gameObject.tag == "Finish") {
            Debug.Log("Your bullet won the game <3");
        }
    }
}
