using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Cheats : EditorWindow
{
    static Cheats instance;

    [MenuItem("Cheats/Options")]
    public static void ShowWindow()
    {
        instance = EditorWindow.GetWindow<Cheats>();
        instance.Show();
    }

    private void OnGUI()
     {
       CheatPrefs.MuteAllSounds =
            EditorGUILayout.Toggle("Mute All Sounds", CheatPrefs.MuteAllSounds);
        CheatPrefs.PlayerLives =
            EditorGUILayout.IntField("Number of Lives", CheatPrefs.PlayerLives);
        CheatPrefs.PlayerTwoName =
            EditorGUILayout.TextField("Player Two Name", CheatPrefs.PlayerTwoName);
     
        GUILayout.FlexibleSpace();

        EditorGUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();

        GUI.backgroundColor = Color.red;

        if (GUILayout.Button("Reset", GUILayout.Width(100), GUILayout.Height(30)))
           {
                CheatPrefs.MuteAllSounds = false;
                CheatPrefs.PlayerLives = 4;
                CheatPrefs.PlayerTwoName = "John";
           }

        EditorGUILayout.EndHorizontal();

    }
}
