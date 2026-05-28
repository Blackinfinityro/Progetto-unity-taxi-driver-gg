using UnityEngine;

public class DestroyCar : MonoBehaviour
{
    
     private void OnTriggerEnter(Collider other){
        if(other.CompareTag("triggerDestroyRoad"))
        {
            Destroy(gameObject);
        }
    }
}
