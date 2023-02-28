using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTransform : MonoBehaviour
{
    public Transform cube;

    void Start()
    {
        cube = GameObject.Find("Cube").transform;
    }
}
