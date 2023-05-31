using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KupHareket : MonoBehaviour
{
    [SerializeField] private float hiz;
    [SerializeField] private float minX, maxX;
    [SerializeField]GameObject _karekter;
    [SerializeField] private GameObject spawnYer;
    private int a;
    public float y;
    
    void Start()
    {
        y = 0.5f;
    }

    
    void Update()
    {
        a = transform.childCount-1;
        print(a);
        var x = Input.GetAxis("Horizontal");
        Vector3 move=new Vector3(0, 0, -1);;
        var xEkseni = transform.position.x + (-x * hiz * Time.deltaTime); 
        xEkseni = Mathf.Clamp(xEkseni, minX, maxX);
        transform.position = new Vector3(xEkseni, 0.5f, transform.position.z);
        transform.Translate(move*hiz*Time.deltaTime); 
       
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("altin"))
        {
            Destroy(other.gameObject);
            Vector3 poz = new Vector3(transform.position.x, y+=1, transform.position.z);
           _karekter= Instantiate(_karekter,poz,transform.rotation);
           _karekter.transform.parent = transform;
        }

        if (other.gameObject.CompareTag("nokta"))
        {
           
            Vector3 konum = new Vector3(spawnYer.transform.position.x,spawnYer.transform.position.y,spawnYer.transform.position.z-90);
           spawnYer=Instantiate(spawnYer,konum,transform.rotation);
          
        }

        if (other.gameObject.CompareTag("engel"))
        {
            int uzunluk = (int)other.transform.localScale.y;
            if (transform.childCount >= uzunluk)
            {
                for (int i=0;i<uzunluk;i++)
                {
                    Destroy(transform.GetChild(a).gameObject);
                }

                a--; 
            }
            else
            {
                print("Game Over");
            }
            
        }
    }
}
