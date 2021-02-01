using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class GenerateRingPath : MonoBehaviour
{
    [Range(10, 60)] public int num = 10;
    [Range(3, 20)] public float radius = 5;
    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();

        // generate a bunch of points!
        float rad = 0;

        Vector3[] pts = new Vector3[num];

        for (int i = 0; i < num; i++)
        {
            pts[i] = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)) * radius;
            rad += (Mathf.PI * 2) / num;
        }
        line.positionCount = num;
        line.SetPositions(pts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
