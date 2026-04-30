using UnityEngine;

public class createRoad : MonoBehaviour
{
    [SerializeField] GameObject CentralRoadPrefab;
    Vector3 spawnPosition =  new Vector3(0f, 0.46f,0f);
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("triggerSpawnRoad"))
        {
            Instantiate(CentralRoadPrefab, spawnPosition, Quaternion.Euler(0, 0, 90f));
        }
    }
}
