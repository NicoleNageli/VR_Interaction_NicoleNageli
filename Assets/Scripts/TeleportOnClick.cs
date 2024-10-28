using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportOnClick : MonoBehaviour
{
    public InputActionReference teleportAction;
    public Transform rightController; 
    void Update()
    {
        if (teleportAction == null)
        {
            Debug.LogError("Teleport action is not assigned!");
            return;
        }

        // Check if the trigger is pressed
        if (teleportAction.action.triggered)
        {
            // Cast a ray from the right controller to see if it hits an object
            Ray ray = new Ray(rightController.position, rightController.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Teleport to the hit point if the object is interactable
                Teleport(hit.point);
            }
        }
    }

    void Teleport(Vector3 targetPosition)
    {
        // Teleport the player to the target position
        transform.position = targetPosition;
        Debug.Log("Teleported to: " + targetPosition);
    }
}
