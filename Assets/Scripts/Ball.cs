using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        AddStartingForce();
    }

    void AddStartingForce()
    {
        float x = Random.value > 0.5f ? 1.0f : -1.0f;
        float y = Random.value > 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }
}
