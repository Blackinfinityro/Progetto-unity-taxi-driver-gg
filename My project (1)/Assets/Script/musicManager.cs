using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class musicManager : MonoBehaviour
{
    public TMP_Dropdown mioDropdown; 
    public Slider sliderVolume; 
    public AudioSource sorgenteAudio;
    
    [Header("Impostazioni Tracce e Skybox")]
    public List<AudioClip> tracceMusicali; 
    public List<Material> skyboxCorrispondenti; 

    private int tracciaSelezionata = 0;
    private float volumeSelezionato = 0.5f;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
       
        if (mioDropdown != null)
        {
            mioDropdown.onValueChanged.AddListener(SalvaSceltaTraccia);
        }

       
        if (sliderVolume != null)
        {
            sliderVolume.value = volumeSelezionato; 
            sliderVolume.onValueChanged.AddListener(CambiaVolume);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scena, LoadSceneMode modalita)
    {
        if (scena.name == "Gioco") 
        {
            ApplicaMusicaESkybox();
        }
        else
        {
            sorgenteAudio.Stop(); 
        }
    }

    void SalvaSceltaTraccia(int indiceTraccia)
    {
        tracciaSelezionata = indiceTraccia;
    }

   
    void CambiaVolume(float nuovoVolume)
    {
        volumeSelezionato = nuovoVolume;
        sorgenteAudio.volume = volumeSelezionato; 
    }

    void ApplicaMusicaESkybox()
    {
        sorgenteAudio.volume = volumeSelezionato;

        if (tracciaSelezionata >= 0 && tracciaSelezionata < tracceMusicali.Count)
        {
            sorgenteAudio.clip = tracceMusicali[tracciaSelezionata];
            sorgenteAudio.Play();
        }

        if (tracciaSelezionata >= 0 && tracciaSelezionata < skyboxCorrispondenti.Count)
        {
            if (skyboxCorrispondenti[tracciaSelezionata] != null)
            {
                RenderSettings.skybox = skyboxCorrispondenti[tracciaSelezionata];
                DynamicGI.UpdateEnvironment(); 
            }
        }
    }
}
