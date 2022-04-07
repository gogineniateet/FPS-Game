using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    float minPerSecond = 60f;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float angleTheFrame = Time.deltaTime / 10 * minPerSecond;
        transform.RotateAround(transform.position, Vector3.forward, angleTheFrame);
    }
}
