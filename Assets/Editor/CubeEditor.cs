using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MyCube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MyCube myCube = (MyCube)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Cambiar Color")) {

            myCube.GenerateColor();
        }

        if (GUILayout.Button("Reset"))
        {

            myCube.Reset();
        }

       

        GUILayout.EndHorizontal();

        myCube.size = EditorGUILayout.Slider(myCube.size, 0f, 1f);
        myCube.transform.localScale = Vector3.one * myCube.size;
    }
}
