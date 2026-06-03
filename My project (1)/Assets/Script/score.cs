using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public int punteggio = 0;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartCoroutine(IncrementEverySecond());
    }

    IEnumerator IncrementEverySecond()
    {
        while (true)
        {
            punteggio += 1;
            yield return new WaitForSeconds(1f);
        }
    }
}