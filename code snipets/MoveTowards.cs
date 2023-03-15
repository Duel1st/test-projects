using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform position;
    private float speed = 10.0f;

    void Start()
    {
        position = GameObject.Find("Position").transform;
    }

    void Update()
    {
        float move = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, position.position, move);
    }
}
