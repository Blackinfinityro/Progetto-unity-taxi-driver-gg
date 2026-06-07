using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    public Toggle toggleTelecamera; 

    private static bool usaTelecameraAlternativa = false;
    

  
    void Awake()
    {
        CameraManager[] gestori = FindObjectsOfType<CameraManager>();
        if (gestori.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        InizializzaToggle();
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
            ApplicaConfigurazioneTelecamera();
        }
        else if (scena.name == "Menù" || scena.buildIndex == 0)
        {
            InizializzaToggle();
        }
    }

    void InizializzaToggle()
    {
        if (toggleTelecamera == null)
        {
            toggleTelecamera = FindObjectOfType<Toggle>();
        }

        if (toggleTelecamera != null)
        {
            toggleTelecamera.isOn = usaTelecameraAlternativa; 
            toggleTelecamera.onValueChanged.RemoveAllListeners();
            toggleTelecamera.onValueChanged.AddListener(SalvaStatoTelecamera);
        }
    }

    void SalvaStatoTelecamera(bool spuntato)
    {
        usaTelecameraAlternativa = spuntato;
    }

    void ApplicaConfigurazioneTelecamera()
    {
        GameObject camPrincipale = GameObject.Find("TelecameraPrincipale");
        GameObject camAlternativa = GameObject.Find("TelecameraAlternativa");

        if (camPrincipale != null && camAlternativa != null)
        {
            camPrincipale.SetActive(!usaTelecameraAlternativa);
            camAlternativa.SetActive(usaTelecameraAlternativa);
        }
        else
        {
            Debug.LogWarning("CameraManager: Non ho trovato 'TelecameraPrincipale' o 'TelecameraAlternativa' nella scena di gioco!");
        }
    }
}
