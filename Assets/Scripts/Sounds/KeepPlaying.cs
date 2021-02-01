using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlaying : MonoBehaviour
{
    private void Awake()
    {
        // puts objects with that tag in array
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        // destroys second instance of music objects
        if (objs.Length > 1) Destroy(this.gameObject);

        // don't destroy if you're the first instance
        DontDestroyOnLoad(this.gameObject);
    }
}
