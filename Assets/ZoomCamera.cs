using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public float zoomIn;
    public float zoomOut;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButton("ZoomView"))
        {
            cam.fieldOfView = zoomIn;
        }
        else
        {
            cam.fieldOfView = zoomOut;
        }
             
    }
}
