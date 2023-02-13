using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour
{
    // Start is called before the first frame update
    public float ms;
    void Start()
    {
        ms = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float x = ms * Time.deltaTime * Input.GetAxis("Horizontal");
        float y = ms * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x, 0f, y);
    }
}
