using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] GameObject kuyruk;
    [SerializeField] GameObject Panel;

    GameObject yeniKuyruk;
    [SerializeField] float spawnHiz;
    void Start()
    {
     Panel.SetActive(false);
    }
   

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0)){
           kuyruk=Instantiate(kuyruk,transform.position,transform.rotation);
       Rigidbody2D rb= kuyruk.GetComponent<Rigidbody2D>();
       rb.AddForce(transform.up*spawnHiz);
        }
       if(childYapma.olduMu==true){
        Panel.SetActive(true);
       }
     
    }
    
   
}
