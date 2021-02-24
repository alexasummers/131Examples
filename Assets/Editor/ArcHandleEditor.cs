using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

[CustomEditor(typeof(ArcHandleDemo))]
class ArcHandleEditor : Editor
{
  ArcHandleDemo m_Target;
  ArcHandle m_Arc;

  private void OnEnable()
  {
      m_Arc = new ArcHandle();
      m_Arc.SetColorWithRadiusHandle(Color.red, 0.2f);
  }

  void OnSceneGUI()
  {
      m_Target = (ArcHandleDemo)target;

      Matrix4x4 handleMatrix = Matrix4x4.TRS(
          m_Target.transform.position,
          m_Target.transform.rotation,
          Vector3.one
      );

      m_Arc.angle = m_Target.Angle;
      m_Arc.radius = m_Target.Radius;

      Handles.color = Color.white;
    using ( new Handles.DrawingScope(handleMatrix))
    {
        m_Arc.DrawHandle();
    }
    m_Target.Angle = m_Arc.angle;
    m_Target.Radius = m_Arc.radius;
  }
}
