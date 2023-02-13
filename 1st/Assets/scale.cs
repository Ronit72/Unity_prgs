using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{
    // Start is called before the first frame update
    public float s;
    void Start()
    {
        s = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
            transform.localScale += new Vector3(s, 0, 0);
        if (Input.GetKey("d"))
            transform.localScale -= new Vector3(s, 0, 0);
        if (Input.GetKey("r"))
            transform.localScale += new Vector3(0, s, 0);
        if (Input.GetKey("f"))
            transform.localScale -= new Vector3(0, s, 0);
        if (Input.GetKey("t"))
            transform.localScale += new Vector3(0, 0, s);
        if (Input.GetKey("g"))
            transform.localScale -= new Vector3(0, 0, s);
    }
}
