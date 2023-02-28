using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] array = new GameObject [2];
    
    void Start()
    {
        array[0] = Resources.Load<GameObject>("Enemy");
        array[1] = Resources.Load<GameObject>("Enemy 2");
    }
}
