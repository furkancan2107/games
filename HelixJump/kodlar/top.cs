using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class top : MonoBehaviour
{
    // Start is called before the first frame update
   public float hiz;
   float fark;
   public Text skorText;
   float skor=0;
   public GameObject gameover;
   
   bool kontrol;
  float ilk;
   public GameObject kamera;
   Rigidbody rb;
   private void Start() {
    gameover.SetActive(false);
    ilk=transform.position.y;

    rb=GetComponent<Rigidbody>();
   }
 
   private void FixedUpdate() {
    Vector3 poz=new Vector3(kamera.transform.position.x,transform.position.y+2,kamera.transform.position.z);
    kamera.transform.position=poz;
    fark=ilk-transform.position.y;
   }
    void OnCollisionEnter(Collision other) {
        kontrol=true;
       rb.velocity=Vector3.up*hiz;
      
       print("true");
       if(other.gameObject.tag=="dusman"){
        // game over panel 
        gameover.SetActive(true);
       }
   }
   private void OnCollisionExit(Collision other) {
    kontrol=false;
     if(fark>2){
        skor+=0.5f*10;
        skorText.text=skor.ToString();
        ilk=transform.position.y;
    }
   }
}
