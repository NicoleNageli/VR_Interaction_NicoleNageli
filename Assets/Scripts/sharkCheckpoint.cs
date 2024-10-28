using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sharkCheckpoint : MonoBehaviour
{
    public string SimpleTeleport = "SimpleTeleport"; // Load simple teleport scene
    public float waitTime = 0.5f; // Time before loading the new scene

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.gameObject.name); // Debug log
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Player entered the checkpoint.");
            StartCoroutine(LoadNewScene());
        }
    }

    private IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(SimpleTeleport); // Load the scene
    }
}
