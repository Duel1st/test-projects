using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadResource : MonoBehaviour
{
    public GameObject cube;
    
    void Start()
    {
        cube = Resources.Load<GameObject>("Cube");
    }
}
