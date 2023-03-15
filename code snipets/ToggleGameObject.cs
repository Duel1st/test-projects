using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject cube;
    public bool isTrue = true;
    private float nextToggle;
    public float toggleRate = 3.0f;

    void Start()
    {
        cube = GameObject.Find("Cube");
        nextToggle = Time.time + toggleRate;
    }

    void Update()
    {
        IsTrue();

        //IsTrueTimer();
    }

    private void IsTrue()
    {
        if (Input.GetKeyDown("space") && isTrue)
        {
            cube.SetActive(false);
            isTrue = false;
        }
        else if (Input.GetKeyDown("space") && !isTrue)
        {
            cube.SetActive(true);
            isTrue = true;
        }
    }

    private void IsTrueTimer()
    {
        if (isTrue && Time.time > nextToggle)
        {
            cube.SetActive(false);
            isTrue = false;
            nextToggle = Time.time + toggleRate;
        }
        else if (!isTrue && Time.time > nextToggle)
        {
            cube.SetActive(true);
            isTrue = true;
            nextToggle = Time.time + toggleRate;
        }
    }
}
