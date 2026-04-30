using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class roadMovement : MonoBehaviour
{
    score istanzaScore;
    
    void Start() {
        istanzaScore = FindAnyObjectByType<score>();
    }

    void Update()
    {
        int velocità = -1*istanzaScore.punteggio;
        transform.Translate(velocità*Time.deltaTime, 0, 0); 
    }
}
