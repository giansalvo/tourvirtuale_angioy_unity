using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    public Camera cam;
    // Use this for initialization
    private void Start()
    {
        definedButton = this.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
       
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Transform definedButton = Hit.transform;
                Debug.Log("Button Clicked");
                OnClick.Invoke();
            }
        }
    }
}