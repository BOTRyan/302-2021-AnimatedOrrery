using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // The tilt of the camera in degress
    private float pitch = 20;
    private float yaw = 0;
    private float roll = 0;
    private float dollyDis = 30;
    private float targetDollyDis = 20;

    public float mouseSensitivityY = 5;
    public float mouseSensitivityX = 5;
    public float mouseScrollMult = 10;

    public GameObject sun;
    public GameObject planet1;
    public GameObject planet2;
    public GameObject planet3;
    public GameObject planet4;
    public GameObject planet5;
    private Vector3 target;

    public int lookAtValue = 0;
    public bool doOnce = true;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        lookAtPlanet();

        transform.position = AnimMath.Slide(transform.position, target, .05f);

        if (Input.GetButton("Fire2"))
        {
            float mouseY = Input.GetAxis("Mouse Y");
            float mouseX = Input.GetAxis("Mouse X");

            pitch -= mouseY * mouseSensitivityY;
            yaw += mouseX * mouseSensitivityX;
        }

        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");

        targetDollyDis -= scroll * mouseScrollMult;
        targetDollyDis = Mathf.Clamp(targetDollyDis, 4, 30);

        dollyDis = AnimMath.Slide(dollyDis, targetDollyDis, .05f); // EASE

        cam.transform.localPosition = new Vector3(0, 0, -dollyDis);

        // changing rotation to match the pitch variable:
        pitch = Mathf.Clamp(pitch, -89, 89);
        
        Quaternion targetRotation = Quaternion.Euler(pitch, yaw, roll);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.01f); // EASE
    }
    void lookAtPlanet()
    {
        if (lookAtValue == 0)
        {
            target = sun.transform.position;
            if (doOnce)
            {
                targetDollyDis = 30;
                doOnce = false;
            }
        }
        else if (lookAtValue == 1){
            target = planet1.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 2)
        {
            target = planet2.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 3)
        {
            target = planet3.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 4)
        {
            target = planet4.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
        else if (lookAtValue == 5)
        {
            target = planet5.transform.position;
            if (doOnce)
            {
                targetDollyDis = 5;
                doOnce = false;
            }
        }
    }
}
