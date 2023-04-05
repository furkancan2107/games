using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topFizik : MonoBehaviour
{
    // Start is called before the first frame update
    public float topHiz;
    [SerializeField] float sagTaraf,solTaraf;
    [SerializeField] Text sag,sol;
float sagSkor=0,solSkor=0;
    Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.velocity=Vector2.right*topHiz;
    }
    private void Update() {
        if(transform.position.x>sagTaraf){
            solSkor+=1;
            sol.text=solSkor.ToString();
            transform.position=new Vector2(0,transform.position.y);
            rb.velocity=-Vector2.right*topHiz;
        }
         if(transform.position.x<solTaraf){
            sagSkor+=1;
            sag.text=solSkor.ToString();
            transform.position=new Vector2(0,transform.position.y);
            rb.velocity=Vector2.right*topHiz;
        }
    }

  
    private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.tag=="racket1")
       {
         float y=topDegme(transform.position,other.transform.position,other.collider.bounds.size.y);
         Vector2 ekle=new Vector2(1,y).normalized;
         rb.velocity=ekle*topHiz;
       } 
      if(other.gameObject.tag=="racket2")
       {
          float y=topDegme(transform.position,other.transform.position,other.collider.bounds.size.y);
         Vector2 ekle=new Vector2(-1,y).normalized;
         rb.velocity=ekle*topHiz;
       } 
    }
    float topDegme(Vector2 topPoz,Vector2 raketPoz,float racketUzunluk){
        float hit=(topPoz.y-raketPoz.y)/racketUzunluk;
        print(hit);
        return hit;
    }
}
