using UnityEngine;
using System.Collections;

public class score : MonoBehaviour
{
    public int punteggio = 0;

    void Start()
    {
        StartCoroutine(IncrementEverySecond());
    }

    IEnumerator IncrementEverySecond()
    {
        while (true)
        {
            punteggio += 1;
            Debug.Log(punteggio);
            yield return new WaitForSeconds(1f);
        }
    }
}