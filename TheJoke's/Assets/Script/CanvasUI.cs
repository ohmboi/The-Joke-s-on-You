using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasUI : MonoBehaviour
{
    public GameObject Obj;
    public float activetime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Obj.active == true)
        {
            StartCoroutine(Disableobj());
        }
    }

    IEnumerator Disableobj()
    {
        yield return new WaitForSeconds(activetime);
        Obj.SetActive(false);
    }
}
