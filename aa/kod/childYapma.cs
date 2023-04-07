using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childYapma : MonoBehaviour
{
   
  public static bool olduMu;
  private void Start() {
    olduMu=false;
  }
   
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="daire"){
           //other.gameObject.transform.parent=transform;
           transform.parent=other.gameObject.transform;
           transform.localScale=new Vector3(0.3f,0.3f,1);
        }
        if(other.gameObject.tag=="dusman"){
            print("gameOver");
            olduMu=true;
        }
    }
}
