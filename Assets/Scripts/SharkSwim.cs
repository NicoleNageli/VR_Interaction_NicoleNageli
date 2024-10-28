using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkSwim : MonoBehaviour
{
     public float bobbingHeight = 0.5f;
     public float bobbingSpeed = 2f;
     public float sideToSideDistance = 2f;
     public float sideToSideSpeed = 1f; 
     private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //up and down bobbing
        float newY = initialPosition.y + Mathf.Sin(Time.time * bobbingSpeed) * bobbingHeight;
        //side to side
        float newX = initialPosition.x + Mathf.Sin(Time.time * sideToSideSpeed) * sideToSideDistance;

        transform.position = new Vector3(newX, newY, initialPosition.z);
        
    }
}
