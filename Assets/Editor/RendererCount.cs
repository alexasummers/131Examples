using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RendererCount : EditorWindow
{
   static RendererCount instance;
   UnityEngine.SceneManagement.Scene currentScene;

   bool hasData = false;
   int meshCount = -1;

   [MenuItem("Tools/Counter/Renderer Counter")]
   
   public static void CreateWindow()
   {
       instance = EditorWindow.GetWindow<RendererCount>();
       instance.Show();
   }

    private void OnGUI()
    {
        GUILayout.Label("Counting Window", EditorStyles.boldLabel);

        currentScene = UnityEditor.SceneManagement.EditorSceneManager.GetActiveScene();
        GUILayout.Space(15);
        GUILayout.Label("Active Scene: " + currentScene.name);

        if(GUILayout.Button("Count"))
        {
            DoCount();
        }

        if(hasData)
        {
            GUILayout.Label("Mesh Renderer Count: " + meshCount);
        }
    }

    private void DoCount()
    {
        meshCount = 0;
        hasData = true;

        foreach(GameObject go in currentScene.GetRootGameObjects())
        {
            CheckForMesh(go);
        }
    }

    private void CheckForMesh(GameObject go)
    {
        meshCount += go.GetComponentsInChildren<MeshRenderer>().Length;
        meshCount += go.GetComponents<MeshRenderer>().Length;
    }
}
