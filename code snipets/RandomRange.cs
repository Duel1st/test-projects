using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRange : MonoBehaviour
{
    public int roll;
    
    void Start()
    {
        roll = Random.Range(0, 11);
        Debug.Log(roll);
    }
}
