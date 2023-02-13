using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    // Start is called before the first frame update
    public float force = 600f;
    void Start()
    {
        // GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -1f) * force * Time.deltaTime);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0f, Random.Range(0.8f, 0.8f), Random.Range(0.8f,0.8f)) * force * Time.deltaTime, ForceMode.Impulse);
    }
}
