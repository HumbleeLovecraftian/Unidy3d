using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
   private new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float horizontal=Input.GetAxisRaw("Horizontal");
      float vertical=Input.GetAxisRaw("Vertical");
      if(horizontal!=0||vertical!=0){
        Vector3 direction=transform.forward * vertical;
      }
        /* rigidbody.velocity */
    }
}
