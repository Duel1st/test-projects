using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    private bool coroutine = false;
    private bool isTrue = false;

    void Update()
    {
        IsTrue();
    }

    private void IsTrue()
    {
        if (coroutine)
        {
            return;
        }
        if (Input.GetKeyDown("space"))
        {
            coroutine = true;
            isTrue = true;
            if (isTrue)
            {
                StartTimer();
            }
        }
    }

    private void StartTimer()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        Debug.Log("Hello");
        yield return new WaitForSeconds(3);
        Debug.Log("Hello... Again");
        coroutine = false;
        isTrue = false;
    }
}
