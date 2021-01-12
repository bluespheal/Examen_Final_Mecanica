using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public Camera cam;
    public GameObject camPosition;
    void Start()
    {
        cam = Camera.main;
    }
    void OnMouseDown()
    {
        Focus(camPosition);
    }

    void Focus(GameObject go)
    {
        cam.transform.position = go.transform.position;
        cam.transform.parent = gameObject.transform;
    }

}
