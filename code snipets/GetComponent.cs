using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    public BoxCollider boxCollider;
    public GameObject cube;
    
    void Start()
    {
        cube = GameObject.Find("Cube");
        boxCollider = cube.GetComponent<BoxCollider>();
    }
}
