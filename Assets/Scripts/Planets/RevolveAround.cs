using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAround : MonoBehaviour
{
    public Transform target;
    public float radius = 5;
    public float speed = 0;

    private float age = 0;
    private float rotY = 0;

    private void Start()
    {
        age = Random.Range(0, 10);
    }

    void Update()
    {
        if (!GameManager.rewind)
        {
            age += Time.deltaTime * GameManager.timeSpeed;
        }
        else
        {
            age -= Time.deltaTime * GameManager.timeSpeed;
        }
        
        Vector3 offset = AnimMath.Revolve(radius, age, speed);

        transform.position = target.position + offset;

        rotY += Time.deltaTime * GameManager.timeSpeed * speed;

        transform.rotation = Quaternion.Euler(0, rotY, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(target.position, radius);
    }
}
