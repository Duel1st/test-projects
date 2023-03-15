using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleComponent : MonoBehaviour
{
    public BoxCollider boxCollider;
    public GameObject cube;    
    private float nextToggle;
    public float toggleRate = 3.0f;

    void Start()
    {
        cube = GameObject.Find("Cube");
        boxCollider = cube.GetComponent<BoxCollider>();
        nextToggle = Time.time + toggleRate;
    }

    void Update()
    {
        IsTrue();

        //IsTrueTimer();
    }

    private void IsTrue()
    {
        if (Input.GetKeyDown("space"))
        {
            boxCollider.enabled = !boxCollider.enabled;
        }
    }

    private void IsTrueTimer()
    {
        if (Time.time > nextToggle)
        {
            boxCollider.enabled = !boxCollider.enabled;
            nextToggle = Time.time + toggleRate;
        }
    }
}
