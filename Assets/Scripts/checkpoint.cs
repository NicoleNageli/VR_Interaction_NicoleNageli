using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkpoint : MonoBehaviour
{
    public string ObjectArc = "ObjectArc"; //load object arc scene
    public float waitTime = .5f; // Time before loading the new scene

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            StartCoroutine(LoadNewScene());
        }
    }

    private IEnumerator LoadNewScene()
    {
        yield return new WaitForSeconds(waitTime); // Optional wait time
        SceneManager.LoadScene(ObjectArc); // Load the new scene
    }
}
