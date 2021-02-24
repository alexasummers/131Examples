using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PositionHandle))]
class PositionHandleEditor : Editor
{
   PositionHandle m_Target;

   void OnSceneGUI()
   {
       m_Target = (PositionHandle)target;

       for( int i = 0; i < m_Target.transform.childCount; ++i )
       {
           Transform Child = m_Target.transform.GetChild(i);

           Child.position = Handles.PositionHandle(Child.position, Child.rotation);
       }
   }
}
