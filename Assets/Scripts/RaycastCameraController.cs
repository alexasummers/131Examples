using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCameraController : MonoBehaviour
{
    private Camera _camera;

    private float _mouseMovement = 200;

   private Transform parent; //reference to our parent object

   private void Start() 
   {
       _camera = GetComponent<Camera>();

       parent = transform.parent; //the parent of our object is the object we want to rotate
       Cursor.lockState = CursorLockMode.Locked;
   }

   private void Update()
   {
       float movement = Input.GetAxis("Mouse X") * _mouseMovement * Time.deltaTime; //multiplying horizontal mouse movement by our mouse movement speed

       parent.Rotate(Vector3.up, movement); //rotate parent around vector3 up axis, controlled by the mouse movement
   }

   void OnGUI() {
       int size = 12;
       float posX = _camera.pixelWidth/2 - size/4;
       float posY = _camera.pixelHeight/2 - size/2;
       GUI.Label(new Rect(posX, posY, 1000, 1000), "+");
   }
}