using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islemler : MonoBehaviour
{
    public float hiz; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=Input.GetAxis("Mouse X");
        if(Input.GetMouseButton(0)){
            transform.Rotate(0,x*hiz,0);
        }
    }
}
