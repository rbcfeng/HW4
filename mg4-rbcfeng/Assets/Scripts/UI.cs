using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject _gameOver;
    void Start()
    {
        GameController.Instance.Player.Triggered += UpdatePoints;
        GameController.Instance.Player.Collided += GameOver;
    }

    public void UpdatePoints()
    {
        _pointsText.text = GameController.Instance.Player._points.ToString();
    }

    public void GameOver()
    {
        _gameOver.SetActive(true);
    }

    void Update()
    {
        
    }
}
