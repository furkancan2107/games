using System;
using UnityEngine;

namespace OYUN.Stack.Kodlar
{
    public class Mek : MonoBehaviour
    {
        private Rigidbody _rb;
        public float hiz;
        public GameObject alt;
        private Collider _size;
        private int _sayac;
        private float _uzunluk, _xpoz;
        [SerializeField] private GameObject gelecek;
        private StackSpawn _stackSpawn;

        private void Awake()
        {
            _stackSpawn = FindObjectOfType<StackSpawn>();
        }

        void Start()
        {
            hiz = 2;
            _rb = GetComponent<Rigidbody>();
            _rb.velocity = new Vector2(hiz, 0);
            //alt=GameObject.Find("alt");
            _size = GetComponent<Collider>();
            _sayac = 0;


        }



        void Update()
        {
            print(_size.bounds.size.x);
            if (Input.GetMouseButtonDown(0) && _sayac == 0)
            {
                hiz = 0;
                _rb.velocity = new Vector2(hiz, 0);
                var x = alt.transform.position.x - transform.position.x;
                print("x" + x);
                _xpoz = (float)(x * 0.534);
                _uzunluk = _size.bounds.size.x - Math.Abs(x);
                print("uzun" + _uzunluk);
                transform.localScale = new Vector3(_uzunluk, 1, 1);
                transform.position = new Vector3(-_xpoz, transform.position.y, transform.position.z);
                alt = transform.gameObject;
                _sayac = 1;
            }

            if (Input.GetMouseButtonUp(0))
            {
                _rb.constraints = RigidbodyConstraints.FreezeAll;
                gelecek = Instantiate(gelecek, _stackSpawn.transform.position, transform.rotation);
            }


            print(hiz);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Untagged"))
            {
                alt = other.gameObject;
            }
           
           

            if (other.gameObject.CompareTag("engel"))
            {
                print("degdi");
                hiz = 2;
                _rb.velocity = new Vector2(hiz, 0);

            }

            if (other.gameObject.CompareTag("engel2"))
            {
                print("degdi");
                hiz = -2;
                _rb.velocity = new Vector2(hiz, 0);

            }
        }

    }
}
