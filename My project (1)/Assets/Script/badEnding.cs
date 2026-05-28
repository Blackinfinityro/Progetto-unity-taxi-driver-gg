using UnityEngine;

public class badEnding : MonoBehaviour
{    private void OnTriggerEnter(Collider other){

        if(other.CompareTag("Enemy"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
