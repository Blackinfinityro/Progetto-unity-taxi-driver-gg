
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    [SerializeField] GameObject CentralRoadPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var manager = FindAnyObjectByType<SpawnRoad>();
        Instantiate(CentralRoadPrefab, Vector3.zero, Quaternion.Euler(0, 0, 90f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
