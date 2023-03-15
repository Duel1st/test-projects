using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public GameObject cube;
    public bool isTrue = false;
    public GameObject parent;
    
    void Start()
    {
        cube = GameObject.Find("Cube");
        parent = GameObject.Find("Parent");
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && !isTrue)
        {
            cube.transform.parent = parent.gameObject.transform;
            isTrue = true;
        }
        else if (Input.GetKeyDown("space") && isTrue)
        {
            cube.transform.parent = null;
            isTrue = false;
        }
    }
}
