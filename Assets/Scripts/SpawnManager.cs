using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
     private float spawnX = 20;
     private float spawnZ = 20;

     private float startdelay = 2;
     private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startdelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    { 

    }

    void SpawnRandomAnimal(){
         int animalIndex = Random.Range(0,animalPrefabs.Length);//generates random animals from array
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX,spawnX),0,spawnZ);//generates random position for animals 
            Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
       
    }
}
