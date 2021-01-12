using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public Camera cam;
    public GameObject camPosition;
    public VariableWatcher varwatch;
    void Start()
    {
        cam = Camera.main;
        varwatch = GameObject.Find("Canvas").GetComponent<VariableWatcher>();
    }
    void OnMouseDown()
    {
        Focus(camPosition);
    }

    void Focus(GameObject go)
    {
        cam.transform.position = go.transform.position;
        cam.transform.parent = gameObject.transform;
        varwatch.UpdateText(gameObject.GetComponent<pelotas_rebote>());
    }

}
