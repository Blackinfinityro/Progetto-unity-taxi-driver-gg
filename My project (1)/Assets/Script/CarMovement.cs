using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarMovement : MonoBehaviour
{
    Score istanzaScore;
    [SerializeField] float moltiplicatoreMovimento = 0;
    void Start() {
        istanzaScore = FindAnyObjectByType<Score>();
    }

    void Update()
    {
        float velocità = moltiplicatoreMovimento*istanzaScore.punteggio;
        transform.Translate(0, 0, velocità*Time.deltaTime); 
    
    }
}