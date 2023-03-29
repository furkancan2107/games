using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelaltinspawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject altin;
    public GameObject karekter;
    void Start()
    {
       for(int i=0;i<3;i++){
InvokeRepeating("altinSpawn",1,8);
       }

        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void altinSpawn(){
       
        float x=Random.Range(-2.5f,2.5f);
        float z=karekter.transform.position.z+Random.Range(20,36);
        float y=Random.Range(0.4f,2.6f);
        Vector3 yon=new Vector3(x,y,z);
        Instantiate(altin,yon,Quaternion.identity);
    }

}
