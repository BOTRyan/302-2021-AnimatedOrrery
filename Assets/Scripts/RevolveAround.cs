using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAround : MonoBehaviour
{
    public Transform target;
    public float radius = 5;
    public float speed = 1;

    private float age = 0;
    
    void Update()
    {
        age += Time.deltaTime;

        Vector3 offset = AnimMath.Revolve(radius, age, speed);

        transform.position = target.position + offset;
    }
}
