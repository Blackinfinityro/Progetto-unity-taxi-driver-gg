using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class roadMovement : MonoBehaviour
{
    score istanzaScore;
    [SerializeField] float moltiplicatoreMovimento = 0;
    void Start() {
        istanzaScore = FindAnyObjectByType<score>();
    }

    void Update()
    {
        float velocità = -1*moltiplicatoreMovimento*istanzaScore.punteggio;
        transform.Translate(velocità*Time.deltaTime, 0, 0); 
    }
}
