using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public Renderer rend;
    public Light lightComp;
    public Color[] colors = new Color[] { new Color(0, 1, 0, 1), new Color(1, 0, 0, 1), new Color(1, 1, 1, 1), new Color(0, 0, 1, 1) };
    public int index = 0;
    void Start()
    {
        Debug.Log(Color.blue);
        rend = gameObject.GetComponent<Renderer>();
        lightComp = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab) || Input.GetKey(KeyCode.Mouse0))
        {
            index = (index + 1) % 4;
            lightComp.color = colors[index];
            rend.material.color = colors[index];
        }
    }
}
