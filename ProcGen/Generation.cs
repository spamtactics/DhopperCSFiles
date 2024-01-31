using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float[,] GenerateNoiseMap(int mapDepth, int mapWidth, float scale, float offsetX, float offsetZ) {
                // create an empty noise map with the mapDepth and mapWidth coordinates
        float[,] noiseMap = new float[mapDepth, mapWidth];
        for (int zIndex = 0; zIndex < mapDepth; zIndex++) {
            for (int xIndex = 0; xIndex < mapWidth; xIndex++) {
                                        // calculate sample indices based on the coordinates, the scale and the offset
                float sampleX = (xIndex + offsetX) / scale;
                float sampleZ = (zIndex + offsetZ) / scale;
                                        // generate noise value using PerlinNoise
                float noise = Mathf.PerlinNoise (sampleX, sampleZ);
                noiseMap [xIndex, zIndex] = noise;
            }
        }
        return noiseMap;
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
