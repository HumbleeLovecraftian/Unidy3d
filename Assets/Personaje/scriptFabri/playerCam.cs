using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCam : MonoBehaviour
{
    public float Xs;
    public float Ys;

    public Transform orientation;

    float  xRotate;
    float  yRotate;

    // Start is called before the first frame update
    private void Start()
    {
    Cursor.lockState= CursorLockMode.Locked;
    Cursor.visible= false; 
    }

    // Update is called once per frame
    private void Update()
   {
        float mouseX= Input.GetAxisRaw("Mouse X") * Time.deltaTime  * Xs;
        float mouseY= Input.GetAxisRaw("Mouse Y") * Time.deltaTime  * Ys;
        yRotate+= mouseX;
        xRotate-= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90F, 90F);
        transform.rotation = Quaternion.Euler(xRotate,yRotate, 0);
        orientation.rotation= Quaternion.Euler(0,yRotate,0);
    }
}
