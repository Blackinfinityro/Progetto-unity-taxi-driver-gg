using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorePausa : MonoBehaviour
{
    public GameObject canvasPausa;

    private bool giocoInPausa = false;
    private badEnding scriptMorte;

    void Start()
    {
        scriptMorte = FindObjectOfType<badEnding>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (scriptMorte != null && canvasPausa != null && !canvasPausa.activeSelf)
            {
                if (FindObjectOfType<badEnding>().canvasMorte.activeSelf) return;
            }

            if (giocoInPausa)
            {
                RiprendiGioco();
            }
            else
            {
                PausaGioco();
            }
        }
    }

    public void PausaGioco()
    {
        giocoInPausa = true;
        if (canvasPausa != null) canvasPausa.SetActive(true);
        
        Time.timeScale = 0f; 

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RiprendiGioco()
    {
        giocoInPausa = false;
        if (canvasPausa != null) canvasPausa.SetActive(false);
        
        Time.timeScale = 1f; 

        Cursor.lockState = CursorLockMode.Confined; 
    }

    public void RiavviaLivello()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TornaAlMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Menù");
    }
}
