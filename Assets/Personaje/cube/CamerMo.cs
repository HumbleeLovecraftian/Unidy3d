using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemiento : MonoBehaviour
{
    public float Xs;
    public float ys;

    public Transform orientation;

    float  xRotate;
    float  yRotate;

    // Start is called before the first frame update
    void Start()
    {
    Cursor.lockState= CursorLockMode.Locked;
    Cursor.visible= false;    
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX= Input.GetAxisRaw("mouse X") * Time.deltaTime  * Xs;
        float mouseY= Input.GetAxisRaw("mouse Y") * Time.deltaTime  * Ys;
        YRotate+= mouseX;
        XRotate-= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90F, 90F);
        Transform.rotation = Quaternion.Euler(xRotate,yRotate, 0);
        orientation.rotation= Quaternion.Euler(0,yRotate,0);
    }