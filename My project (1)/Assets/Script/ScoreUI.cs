using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int displayedScore = 0;
    private int lastDisplayStep = 0;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = scoreText.transform.localScale;
    }

    void Update()
    {
        int realScore = Score.Instance.punteggio;

        int targetDisplay = realScore * 10;

        displayedScore = (int)Mathf.Lerp(displayedScore, targetDisplay, Time.deltaTime);

        scoreText.text =  displayedScore.ToString();

        int currentStep = displayedScore / 100;

        if (currentStep != lastDisplayStep)
        {
            lastDisplayStep = currentStep;
            StopAllCoroutines();
            StartCoroutine(Pop());
        }
    }

    IEnumerator Pop()
    {
        scoreText.transform.localScale = originalScale * 1.4f;

        yield return new WaitForSeconds(0.1f);

        scoreText.transform.localScale = originalScale;
    }
}