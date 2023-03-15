using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topHareket : MonoBehaviour
{
    Vector3 yon;
    public GameObject panel;
    public GameObject kamera;
    public Text skorText;
    public GameObject altin;
    public Color[] colors=new Color[6];
    int index;
     float skor=0;
    public float hiz;
   
    public Material zeminRenk;
    float random;
   
    void Start()
    {
        zeminRenk.color=colors[0];
        panel.SetActive(false);
        yon=Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
       
        kamera.transform.position=new Vector3(transform.position.x+3,kamera.transform.position.y,transform.position.z-3);
         if(Input.GetMouseButtonDown(0)){
            skor++;
            skorText.text=skor.ToString();
        if(yon.x==0){
        yon=Vector3.left;

        }
        else{
            yon=Vector3.forward;
        }
         }
         index=Random.Range(0,6);
         if(skor%50==0 && skor!=0){
            zeminRenk.color=colors[index];
         }


    }
     void FixedUpdate() {
        gameOver();
    hareket();    
    }
    void hareket(){
Vector3 pozisyon=yon*Time.deltaTime*hiz;
        transform.position+=pozisyon;    
        }
           void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="yer"){
            Destroy(other.gameObject,2);
        }
    
        
    }
    void gameOver(){
        if(transform.position.y<0){
            print("gameOver");
            panel.SetActive(true);
        }
        
    }
 
 
   
}
