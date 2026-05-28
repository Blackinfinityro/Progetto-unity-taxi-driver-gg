using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioScena : MonoBehaviour
{
   public void cambiaScena (string nomeScena)
    {
        SceneManager.LoadScene(nomeScena);
    }
}
