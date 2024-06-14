using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX=20;
    private float spawnPosZ=20;
    private float startDelay=0;
    private float spawnInterval=0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(方法名，调用方法之前的延迟时间，每次后续调用之间的延迟时间)
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
        //如果要停止repeat，可以用CancelInvoke("Invoke里的方法名")，CancelInvoke停止所有
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
