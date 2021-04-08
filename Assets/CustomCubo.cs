using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenerateColor();
    }

    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
