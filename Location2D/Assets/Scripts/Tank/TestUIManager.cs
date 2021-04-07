using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUIManager : MonoBehaviour
{
    [Header("UI Manager Attributes")]
    public GameObject tank;
    public GameObject fuel;
    public Text tankPosition;
    public Text fuelPosition;
    public Text energyAmount;

    // Start is called before the first frame update
    void Start()
    {
        //tankPosition.text = tank.transform.position.ToString();

        tankPosition.text = tank.GetComponent<TestTankMovement>().currentLocation.ToString();

        fuelPosition.text = fuel.GetComponent<TestObjectManager>().fuelPosition.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnergy(string amount)
    {
        int number;
        if(int.TryParse(amount,out number))
        {
            energyAmount.text = amount;
        }
    }
}
