
using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{

    Color color;
    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Colorizer");
    }

    

    private void OnGUI()
    {
        GUILayout.Label("Colorize selection", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);



        if (GUILayout.Button("Colorize"))
        {
            Colorize();
        }
    }

    private void Colorize()
    {
        foreach (GameObject objt in Selection.gameObjects)
        {

            Renderer renderer = objt.GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }

        }
    }
}
