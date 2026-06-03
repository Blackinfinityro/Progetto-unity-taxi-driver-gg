using UnityEngine;

public class createPalace : MonoBehaviour
{
    [SerializeField] GameObject PalacePrefab;        

     public Vector3 spawnPosition = new Vector3(107.8f,-20.8f,80f);

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("triggerSpawnRoad"))
        {
            Instantiate(PalacePrefab, spawnPosition, Quaternion.Euler(0, 0, 0));
        }
    }
}
