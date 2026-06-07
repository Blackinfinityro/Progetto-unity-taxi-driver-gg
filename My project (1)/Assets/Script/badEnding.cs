using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class badEnding : MonoBehaviour
{
    public GameObject canvasMorte;
    
    [Header("Pulsanti di Scelta")]
    public GameObject pulsanteRiavvia;
    public GameObject pulsanteMenu;

    [Header("Effetto Sonoro Morte")]
    public AudioClip suonoMorte; 

    private AudioSource audioSourceLocale;
    private bool Morto = false;

    void Awake()
    {
        audioSourceLocale = GetComponent<AudioSource>();
        audioSourceLocale.playOnAwake = false;
        
        audioSourceLocale.ignoreListenerPause = true; 
    }

    [ContextMenu("Simula Morte")] 
    public void RiproduciMorte()
    {
        if (Morto) return;
        Morto = true;

        musicManager managerMusica = FindObjectOfType<musicManager>();
        if (managerMusica != null && managerMusica.sorgenteAudio != null)
        {
            managerMusica.sorgenteAudio.Stop();
        }

        if (audioSourceLocale != null && suonoMorte != null)
        {
            audioSourceLocale.clip = suonoMorte;
            audioSourceLocale.Play();
        }

        if (canvasMorte != null)
        {
            canvasMorte.SetActive(true);
        }

        if (pulsanteRiavvia != null) pulsanteRiavvia.SetActive(false);
        if (pulsanteMenu != null) pulsanteMenu.SetActive(false);

        StartCoroutine(SequenzaMorte());
    }

    IEnumerator SequenzaMorte()
    {
        float durataRallentamento = 3f; 
        float tempoTrascorso = 0f;

        while (tempoTrascorso < durataRallentamento)
        {
            tempoTrascorso += Time.unscaledDeltaTime; 
            float percentuale = tempoTrascorso / durataRallentamento;
            Time.timeScale = Mathf.Lerp(1f, 0.01f, percentuale); 
            yield return null; 
        }

        Time.timeScale = 0.0001f; 

        yield return new WaitForSecondsRealtime(1.5f);

        if (pulsanteRiavvia != null) pulsanteRiavvia.SetActive(true);
        if (pulsanteMenu != null) pulsanteMenu.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OpzioneRiavviaLivello()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OpzioneTornaAlMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Menù"); 
    }
}
