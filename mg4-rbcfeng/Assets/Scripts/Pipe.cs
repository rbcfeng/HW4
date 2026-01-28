using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
     [SerializeField] private float _speed;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if(transform.position.x <= -9)
        {
            Destroy(gameObject);
        }
    }
}
