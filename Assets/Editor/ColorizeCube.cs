
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(CustomCubo))]
public class ColorizeCube : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CustomCubo customCubo = (CustomCubo)target;

        if (GUILayout.Button("Colorize")) {

            Debug.Log("APRTASTE EL BOTON");

            customCubo.GenerateColor();
        }
    }
}
