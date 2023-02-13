using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour
{
    // Start is called before the first frame update
    public float move;
    void Start()
    {
        move = 500f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f , move * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0f, move * Time.deltaTime * Input.GetAxis("Horizontal"), 0f );
    }
}
