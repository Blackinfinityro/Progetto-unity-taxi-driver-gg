using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class palaceMovement : MonoBehaviour
{
    public float velocità = 0;
    Score istanzaScore;
    [SerializeField] float moltiplicatoreMovimento = 0;
    void Start() {
        istanzaScore = FindAnyObjectByType<Score>();
    }

    void Update()
    {
        
        velocità = -1*moltiplicatoreMovimento*istanzaScore.punteggio;
        transform.Translate(0, 0, velocità*Time.deltaTime); 
    }
}
