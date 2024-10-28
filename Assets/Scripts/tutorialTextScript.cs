using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutorialTextScript : MonoBehaviour
{
    public TextMeshProUGUI tutorialText;
    public float displayTime = 5f; // Time in seconds to display the tutorial text
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HideTutorialText());
    }
    private IEnumerator HideTutorialText()
    {
        yield return new WaitForSeconds(displayTime);
        tutorialText.gameObject.SetActive(false); // Hide the text
    }
}
