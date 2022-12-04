using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ChangeFurnitureColor : MonoBehaviour
{
    // private ARRaycastManager aRRaycastManager;
    public Camera aRCamera;

    private GameObject objectToMove;

    void Update()
    {
        Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            Ray ray = Camera.current.ScreenPointToRay(touch.position);
            RaycastHit hitObject;
            if (Physics.Raycast(ray, out hitObject))
            {
                objectToMove = hitObject.transform.parent.transform.parent.gameObject;
                objectToMove.GetComponent<Recolour>().SetSelected();
                
            }
        }       
    }


    // Lovish
    public void SetMaterial1()
    {
        objectToMove.GetComponent<MyOwnReColor>().SetSelected1();
    }

    public void SetMaterial2()
    {
        objectToMove.GetComponent<MyOwnReColor>().SetSelected2();
    }

    public void SetMaterial3()
    {
        objectToMove.GetComponent<MyOwnReColor>().SetSelected3();
    }

    public void SetOriginal()
    {
        objectToMove.GetComponent<MyOwnReColor>().SetOriginalMaterial();
    }

}
