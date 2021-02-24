using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor( typeof( HelloWorld ))]

class HelloWorldEditor : Editor
{
   HelloWorld m_Target;

   void OnSceneGUI()
   {
       m_Target = (HelloWorld)target;

       Handles.BeginGUI();
       {
           GUIStyle boxStyle = new GUIStyle ("box");

           GUILayout.BeginArea( new Rect ( 10, 10, 200, 70), boxStyle );
           {
               GUILayout.Label("GUI Layout Demo");
               m_Target.TestValue = GUILayout.HorizontalScrollbar( m_Target.TestValue, 1.0f, 0.0f, 10.0f);

               if( GUILayout.Button("Hello, World!"))
               {
                   Debug.Log( "Hello, World!");
               }
           }
           GUILayout.EndArea();
       }
       Handles.EndGUI();
   }
}
