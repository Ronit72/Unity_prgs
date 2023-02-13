using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 100f;
    private Rigidbody rbody;
    private Renderer rend;
    public Vector3 jump;
    public float jumpForce = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        jump = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float moveX = -1* inputX * moveSpeed * Time.deltaTime;
        float moveZ = -1* inputZ * moveSpeed * Time.deltaTime;
        rbody.AddForce(moveX, 0f, moveZ);
        if (Input.GetKey(KeyCode.Space))
        {
            rbody.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Cube (1)" || col.collider.name == "Cube (2)")
        {
            rend.material.color = Color.blue;
        }
        else if (col.collider.name == "Cube (3)")
        {
            rend.material.color = Color.green;
        }
        else if (col.collider.name == "Cube" || col.collider.name == "Cube (4)")
        {
            rend.material.color = Color.red;
        }
    }
}
