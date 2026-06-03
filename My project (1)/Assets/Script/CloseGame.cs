using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class CloseGame : MonoBehaviour
{
    public void EsciDalGioco()
    {
        Application.Quit();
        
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
    }
}
