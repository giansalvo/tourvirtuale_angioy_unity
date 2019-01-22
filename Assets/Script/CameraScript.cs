using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speedH = 10.0f;
    private float pitch = 0.0f;

    void Start()
    {

    }


    void Update()
    {
        pitch += speedH * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(0.0f,pitch, 0.0f);
    }
}




