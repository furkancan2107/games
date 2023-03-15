using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    float zaman=0;
   
  public GameObject sonYer;
 

    void Start()
    {  
      spawnYap();
      
    }
    private void Update() {
        
        zaman+=Time.deltaTime;
        if(zaman>4){
spawnYap();
zaman=0;
        }
        //print(zaman);
        
    }

   /* IEnumerator spawnYap(){
        yield return new WaitForSeconds(0);
        spawn();
    }*/
    void spawnYap(){
for(int i=0;i<15;i++){
    spawn();
}
    }
    void spawn(){
        
Vector3 Spawnyon;
       if(Random.Range(0,2)==0){
Spawnyon=Vector3.left;
       }
       else{
        Spawnyon=Vector3.forward;
       }
        sonYer=Instantiate(sonYer,sonYer.transform.position+Spawnyon,transform.rotation);
      
            }
 
  
}
