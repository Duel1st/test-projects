using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastLaser : MonoBehaviour
{
    public LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void FixedUpdate()
    {
        Shoot();
    }

    private void Shoot()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out hit, 1000, layerMask))
        {
            if (hit.collider)
            {
                lineRenderer.SetPosition(1, new Vector3(0, hit.distance, 0));
            }
        }
    }
}
