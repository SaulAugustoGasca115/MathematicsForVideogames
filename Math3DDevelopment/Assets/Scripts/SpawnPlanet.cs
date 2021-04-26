﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GenerateSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateSpawn()
    {
        for(int i = 0;i< 2000;i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = Random.insideUnitSphere * 1000.0f;
        }
    }
}