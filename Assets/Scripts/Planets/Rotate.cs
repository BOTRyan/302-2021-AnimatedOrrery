using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float offset = 0;
    Material m_Material;

    private void Start()
    {
        m_Material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        m_Material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        offset = offset + .01f * Time.deltaTime * GameManager.timeSpeed;
    }
}