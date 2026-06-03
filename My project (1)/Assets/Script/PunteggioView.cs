using UnityEngine;
using TMPro;
using System.Collections;

public class PunteggioView : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int lastScore = 0;
    private Vector3 originalScale;

    void Start()
    {
        originalScale = scoreText.transform.localScale;
    }

    void Update()
    {
        int currentScore = Score.Instance.punteggio * 1000;

        scoreText.text = currentScore.ToString();

        if (currentScore != lastScore)
        {
            StopAllCoroutines();
            StartCoroutine(PopAnimation());
            lastScore = currentScore;
        }
    }

    IEnumerator PopAnimation()
    {
        scoreText.transform.localScale = originalScale * 1.4f;

        yield return new WaitForSeconds(0.1f);

        scoreText.transform.localScale = originalScale;
    }
}