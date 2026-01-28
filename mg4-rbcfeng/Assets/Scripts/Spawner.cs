using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;
    void Start()
    {
        InvokeRepeating("SpawnPipe", 1f, 5f);
    }

    
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        float Height = Random.Range(-4, 1);
        
        Instantiate(_pipePrefab, new Vector3(11, Height, 0), Quaternion.identity);
    }
}
