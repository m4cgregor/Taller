using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrodundDetection : MonoBehaviour
{

    Ray ray; 
    float distance; 
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, distance)) {

            Debug.Log("Toco: " + hit.collider.name);
        
        }
    }
    
}
