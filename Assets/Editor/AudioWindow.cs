using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AudioWindow : EditorWindow
{
    bool bgMusicToggle = false;
    bool audio1Toggle = false;
    bool audio2Toggle = false;
    static float bgVolume = 10.0f;
    static float audio1Volume = 10.0f;
    static float audio2Volume = 10.0f;
    static AudioWindow instance;

    [MenuItem("Audio/Options")]
    
    public static void ShowWindow()
    {
        instance = EditorWindow.GetWindow<AudioWindow>();
        instance.Show();
    }

    private void OnGUI()
     {
         bgMusicToggle = EditorGUILayout.Toggle("Mute background music", bgMusicToggle);
         audio1Toggle = EditorGUILayout.Toggle("Mute shooting effect", audio1Toggle);
         audio2Toggle = EditorGUILayout.Toggle("Mute explosion effect", audio2Toggle);

         bgVolume = EditorGUILayout.Slider("Background volume: ", bgVolume, 1, 10);
         audio1Volume = EditorGUILayout.Slider("Shooting volume: ", audio1Volume, 1, 10);
         audio2Volume = EditorGUILayout.Slider("Explosion volume: ", audio2Volume, 1, 10);

         GUILayout.Button("Play Shooting effect");
         GUILayout.Button("Play Explosion effect");
    }
}
