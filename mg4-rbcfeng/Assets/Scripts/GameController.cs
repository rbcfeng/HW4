using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance {get; private set;}
    public Player Player {get; private set;}
    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject playerObj = GameObject.FindWithTag("Player");
        Player = playerObj.GetComponent<Player>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
