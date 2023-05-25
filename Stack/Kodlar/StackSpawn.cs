
using OYUN.Stack.Kodlar;
using UnityEngine;
using Object = System.Object;

public class StackSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    private Mek _mek;
    private GameObject _alt;
    [SerializeField] private GameObject gelecek;
    float _y;
    
    
    private void Awake()
    {
        
        _mek = FindObjectOfType<Mek>();
        
    }

    void Start()
    {
        
        _y = 2.54f;
        //newScale = _mek.transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            
            _alt = _mek.alt.gameObject;
            transform.position=new Vector3(0,_y,-2.904f);
            _y += 1;
        }
    }
}
