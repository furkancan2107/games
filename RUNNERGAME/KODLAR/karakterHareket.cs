using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class karakterHareket : MonoBehaviour
{
    // Start is called before the first frame update
    public float ilerlemeHiz;
    float skor;
    public Text skorText;
    Animator animator;
    
   
    public float ziplamaHiz;
        float yatay;
    float xEkseni;
    float yEkseni;

    public GameObject zemin;
    Rigidbody rb;
    CapsuleCollider cb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        cb=GetComponent<CapsuleCollider>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         
         if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            yatay=Input.GetAxis("Horizontal");
        }
        else{
            yatay=0;
        }
        if(Input.GetKeyDown(KeyCode.W)){
           
          rb.velocity=Vector3.up*ziplamaHiz;
          animator.SetTrigger("ziplama");
        }
        if(Input.GetKey(KeyCode.S)){
           // transform.localScale=new Vector3(1,0.2f,2);
           animator.SetTrigger("takla");
           cb.height=0.5f;
           
        }
        else{
            cb.height=1.800991f;
        }
       // print(cb.height);
       
        if(Input.GetKeyUp(KeyCode.S)){
            
            //transform.localScale=new Vector3(1,1,1);
        }
        xEkseni=transform.position.x+yatay*Time.deltaTime*ilerlemeHiz;
        xEkseni=Mathf.Clamp(xEkseni,-4.3f,4.2f);
        yEkseni=transform.position.y;
        yEkseni=Mathf.Clamp(yEkseni,0,3.3f);
        transform.position=new Vector3(xEkseni,yEkseni,transform.position.z);
        Vector3 move=new Vector3(0,0,1);
        transform.Translate(move*ilerlemeHiz*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="nokta"){
             Vector3 poz=new Vector3(0,0,40);
             
            zemin=Instantiate(zemin,zemin.transform.position+poz,Quaternion.identity);  
        }
        if(other.gameObject.tag=="altin"){
            skor++;
            print(skor);
            skorText.text=skor.ToString();
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision yer) {
         if(yer.gameObject.tag=="yer"){
            Destroy(yer.gameObject,8);
            print("yer");
        }
        if(yer.gameObject.tag=="engel"){
            print("game over");
        }
    }
   
}
