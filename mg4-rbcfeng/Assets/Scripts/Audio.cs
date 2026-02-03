using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource _hitSound;
    [SerializeField] private AudioSource _collectSound;
    void Start()
    {
        GameController.Instance.Player.Collided += HitAudio;
        GameController.Instance.Player.Triggered += CollectAudio;
    }

    public void HitAudio()
    {
        _hitSound.Play();
    }

    public void CollectAudio()
    {
        _collectSound.Play();
    }
   
    void Update()
    {
        
    }
}
