using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballJump : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField] Text text;
    [SerializeField] GameObject panel;

    [SerializeField] float topHiz;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * topHiz;
        panel.SetActive(false);
        text.text = "Game Over";
    }

    // Update is called once per frame
    void Update()
    {
        isWin();
    }
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("kup"))
        {
            float x = hit(transform.position, other.transform.position, other.collider.bounds.size.x);
            Vector2 ekle = new Vector2(x, -1).normalized;
            rb.velocity = ekle * topHiz;
            Destroy(other.gameObject, 0.2f);
        }
        if (other.gameObject.CompareTag("arac"))
        {
            float x = hit(transform.position, other.transform.position, other.collider.bounds.size.x);
            Vector2 ekle = new Vector2(x, 1).normalized;
            rb.velocity = ekle * topHiz;
        }
        if (other.gameObject.CompareTag("dusman"))
        {
            print("Game Over");
            text.text = "Game Over";
            panel.SetActive(true);
        }
    }
    float hit(Vector2 topPoz, Vector2 kupPoz, float kupX)
    {
        float hit = (topPoz.x - kupPoz.x) / kupX;
        return hit;
    }
    void isWin()
    {
        GameObject platform = GameObject.Find("Platform");
        int childSayi = platform.transform.childCount;
        print(childSayi);
        if (childSayi == 0)
        {
            print("Kazandin");
            text.text = "Complate";
            panel.SetActive(true);
        }

    }
}
