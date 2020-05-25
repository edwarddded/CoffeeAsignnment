using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject greenplatformprefab;
    public GameObject RedPlatformPrefab;
    public int numberofgreenplatform;
    public int numberOfRedPlatform;
    public float minGreenY;
    public float maxGreenY;
    public float minRedY;
    public float maxRedY;
    public float levelwidth;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition1 = new Vector3();
        Vector3 spawnPosition2 = new Vector3();
        for (int i = 0; i < numberofgreenplatform; i++)
        {
            spawnPosition1.y += Random.Range( - levelwidth, levelwidth);
            spawnPosition1.x += Random.Range(minGreenY, maxGreenY);
            Instantiate(greenplatformprefab, spawnPosition1, Quaternion.identity);
        }
        for (int i = 0; i < numberOfRedPlatform; i++)
        {
            spawnPosition2.y += Random.Range(-levelwidth, levelwidth);
            spawnPosition2.x += Random.Range(minRedY, maxRedY);
            Instantiate(RedPlatformPrefab, spawnPosition2, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
