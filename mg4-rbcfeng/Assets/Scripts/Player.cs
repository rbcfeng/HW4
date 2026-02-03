using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jump;
    [SerializeField] private AudioSource _jumpSound;
    public int _points;
    public delegate void CollideDelegate();
        public event CollideDelegate Collided;

    public delegate void TriggerDelegate();
        public event TriggerDelegate Triggered;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _jumpSound.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        string tag = collider.gameObject.tag;
        if(tag == "Pipe")
        {
            Destroy(collider.gameObject);
        }
        this.enabled = false;
        Collided?.Invoke();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        string tag = collider.gameObject.tag;
        if(tag == "Pipe")
        {
            _points++;
            Triggered?.Invoke();
        }
    }
}
