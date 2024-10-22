using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    public float jumpforse = 10.0f;
    private Vector3 moveVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}
