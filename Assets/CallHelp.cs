using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallHelp : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Help")) // calling helicoptor
        {
            Debug.Log("Calling for help");
            audioSource.Play();
        }
    }
}
