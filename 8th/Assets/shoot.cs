using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float movespeed = 10f;
    void Update()
    {
        transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal") * movespeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 20f, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 20f);
            if (hit)
            {
                Debug.Log("hit" + hit.collider.name);
                hit.transform.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
    }
}
