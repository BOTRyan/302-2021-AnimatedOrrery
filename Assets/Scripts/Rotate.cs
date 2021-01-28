using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float rotY = 0;
    private float speed = 0.25f;

    // Update is called once per frame
    void Update()
    {
        rotY += Time.deltaTime * speed;

        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }
}