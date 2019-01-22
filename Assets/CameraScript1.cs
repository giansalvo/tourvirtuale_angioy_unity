using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CameraScript1 : MonoBehaviour {
public Camera Camera1;
public Camera Camera2;
public Camera Camera3;

public void EnableCamera1() 
	{       
	Camera1.enabled=true;
    Camera2.enabled=false;
    Camera3.enabled=false;
    }
public void EnableCamera2() 
	{
        Camera1.enabled = false;
        Camera2.enabled = true;
        Camera3.enabled = false;
    }
public void EnableCamera3() 
	{
        Camera1.enabled = false;
        Camera2.enabled = false;
        Camera3.enabled = true;

    }

}

		



