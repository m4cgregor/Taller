using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCube : MonoBehaviour
{

    public float size;
    // Start is called before the first frame update
    void Start()
    {
        GenerateColor();
    }

    public void GenerateColor() {

        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV(0f,1f, .5f, 1f, .5f,1f, 1f, 1f);

    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
