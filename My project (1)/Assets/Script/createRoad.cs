using UnityEngine;

public class createRoad : MonoBehaviour
{
    [SerializeField] GameObject CentralRoadPrefab;
    Vector3 spawnPosition =  new Vector3(0f, 0f,10f);
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("triggerSpawnRoad"))
        {
            Instantiate(CentralRoadPrefab, spawnPosition, Quaternion.Euler(270f, 180f, 90f));
        }
    }
}
