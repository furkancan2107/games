using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aracMove : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float hiz;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x, 0) * hiz;

    }
}
