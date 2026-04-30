using UnityEngine;

public class destroyRoad : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("triggerDestroyRoad"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
    
}
