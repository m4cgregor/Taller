using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiCubito : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {

            transform.Translate(-1f, 0, 0);
        
        }

        if(Input.GetKeyDown(KeyCode.D)) {

            transform.Translate(1f, 0, 0);

        }

    }
}
