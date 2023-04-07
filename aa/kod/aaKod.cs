using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaKod : MonoBehaviour
{
   [SerializeField] float speed;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 move=new Vector3(0,0,1);
        transform.Rotate(move*speed*Time.deltaTime);
    }
}
