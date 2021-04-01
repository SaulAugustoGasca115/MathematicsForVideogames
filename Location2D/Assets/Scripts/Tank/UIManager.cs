﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;

    // Start is called before the first frame update
    void Start()
    {
        tankPosition.text = tank.transform.position.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
