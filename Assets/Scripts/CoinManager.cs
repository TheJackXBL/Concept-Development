using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject[] spawnPoints;

    GameObject[] existingCoins;

    GameObject spawnedCoin;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoins()
    {

        //Delete all existing coins


        existingCoins = GameObject.FindGameObjectsWithTag("Coin");

        for (int i = 0; i < existingCoins.Length; i++)
        {
            Destroy(existingCoins[i]);
        }

        //Spawn in fresh coins

        foreach (GameObject point in spawnPoints)
        {
            spawnedCoin = Instantiate(coin, point.transform.position, point.transform.rotation);
            spawnedCoin.transform.parent = gameObject.transform;
        }
    }
}
