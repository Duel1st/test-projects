using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.tag == "Collision")
        {
            Debug.Log("Collision");
        }
    }

    //void OnCollisionExit(UnityEngine.Collision other)
    //{
    //    if (other.gameObject.tag == "Collision")
    //    {
    //        Debug.Log("Collision");
    //    }
    //}

    //void OnCollisionStay(UnityEngine.Collision other)
    //{
    //    if (other.gameObject.tag == "Collision")
    //    {
    //        Debug.Log("Collision");
    //    }
    //}
}
