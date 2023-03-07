using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;
    private float riglefmove;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        riglefmove = Input.GetAxisRaw("Horizontal") * speed;
    }
}
