using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] cars;
    [SerializeField] Transform[] spawnPoint;
    [SerializeField] int timer;
    [SerializeField] bool moltiplicatore;
    score istanzaScore;
    roadMovement istanzaVelocità;

     IEnumerator Start()
    {
        istanzaScore = FindAnyObjectByType<score>();
        istanzaVelocità = FindAnyObjectByType<roadMovement>();

        if (moltiplicatore == true)
        {
            yield return null;
            while (true)
            {
                SpawnRandomCar();
                Debug.Log($"attesa: {timer*10/istanzaVelocità.velocità}");
                yield return new WaitForSeconds(timer/Mathf.Abs(istanzaVelocità.velocità));
            }
        } else
        {
            while (true)
            {
                SpawnRandomCar();
                yield return new WaitForSeconds(timer);
            }
        }
        
        
    }
    void SpawnRandomCar()
    {
        int randomIndexSpawn = Random.Range(0, 6);
        if (randomIndexSpawn == 0)
        {
            int randomIndexCar = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[0].position, spawnPoint[0].rotation);
        } else if (randomIndexSpawn == 1)
        {
            int randomIndexCar = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[1].position, spawnPoint[1].rotation);
        } else if (randomIndexSpawn == 2)
        {
            int randomIndexCar = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[2].position, spawnPoint[2].rotation);
        } else if (randomIndexSpawn == 3)
        {
            int randomIndexCar = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[0].position, spawnPoint[0].rotation);
            int randomIndexCar2 = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar2], spawnPoint[1].position, spawnPoint[1].rotation);
        } else if (randomIndexSpawn == 4)
        {
            int randomIndexCar = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[0].position, spawnPoint[0].rotation);  
            int randomIndexCar2 = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[2].position, spawnPoint[2].rotation);
        } else if (randomIndexSpawn == 5){
            int randomIndexCar = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[1].position, spawnPoint[1].rotation);
            int randomIndexCar2 = Random.Range(0, cars.Length);
            Instantiate(cars[randomIndexCar], spawnPoint[2].position, spawnPoint[2].rotation);
        }
    }
}