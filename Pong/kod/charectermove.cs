using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charectermove : MonoBehaviour
{
    
    [SerializeField]string axis;
    Rigidbody2D rb;
    [SerializeField] float hiz;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float y=Input.GetAxis(axis);
        rb.velocity=new Vector2(0,y)*hiz;

        
    }
}
