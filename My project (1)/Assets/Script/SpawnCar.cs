using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private float timer = 1f;
    [SerializeField] private bool moltiplicatore = false;

    private Score istanzaScore;
    private roadMovement istanzaVelocità;

    IEnumerator Start()
    {
        istanzaScore = FindAnyObjectByType<Score>();
        istanzaVelocità = FindAnyObjectByType<roadMovement>();

        yield return new WaitForSeconds(3f);

        while (true)
        {
            SpawnRandomCar();

            if (moltiplicatore)
            {
                float attesa = timer / Mathf.Abs(istanzaVelocità.velocità);
                Debug.Log($"Attesa: {attesa}");
                yield return new WaitForSeconds(attesa);
            }
            else
            {
                yield return new WaitForSeconds(timer);
            }
        }
    }

    void SpawnCar(int spawnIndex)
    {
        int randomCarIndex = Random.Range(0, cars.Length);

        Instantiate(
            cars[randomCarIndex],
            spawnPoint[spawnIndex].position,
            spawnPoint[spawnIndex].rotation
        );
    }

    void SpawnRandomCar()
    {
        int randomIndexSpawn = Random.Range(0, 6);

        switch (randomIndexSpawn)
        {
            case 0:
                SpawnCar(0);
                break;

            case 1:
                SpawnCar(1);
                break;

            case 2:
                SpawnCar(2);
                break;

            case 3:
                SpawnCar(0);
                SpawnCar(1);
                break;

            case 4:
                SpawnCar(0);
                SpawnCar(2);
                break;

            case 5:
                SpawnCar(1);
                SpawnCar(2);
                break;
        }
    }
}