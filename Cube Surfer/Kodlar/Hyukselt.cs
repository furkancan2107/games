using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyukselt : MonoBehaviour
{
    // Start is called before the first frame update
    private KupHareket _kupHareket;
    
    private void Awake()
    {
        _kupHareket = FindObjectOfType<KupHareket>();
    }

    void Start()
    {
        transform.position = _kupHareket.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 poz = new Vector3(_kupHareket.transform.position.x, _kupHareket.y, _kupHareket.transform.position.z);
        transform.position = poz;
    }
}
