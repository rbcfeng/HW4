using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jump;
    public delegate void CollideDelegate();
        public event CollideDelegate Collided;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            //add a jump sound
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        //disable player movement and destroy pipe
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //you get a point ig, play a cool sound effect
    }
}
