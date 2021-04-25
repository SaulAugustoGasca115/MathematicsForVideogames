using System.Collections;
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
    public Text energyAmount;
    public int otherValue;
    int n;

    // Start is called before the first frame update
    void Start()
    {
        if(tank != null)
        {
            tankPosition.text = tank.transform.position.ToString();
        }
        
        if(fuel != null)
        {
            fuelPosition.text = fuel.GetComponent<ObjectManager>().objectPosition.ToString();
        }
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(n);
        GetValue();
    }

    public int OtherValue
    {
        get
        {
            return otherValue;
        }
        set
        {
            otherValue = value;
        }
    }


    public int GetValue()
    {
        return otherValue;
    }

    //public int getN()
    //{
    //    return value;
    //}

    //public void setN(int value)
    //{
    //    //value = 50;
    //    this.value = value;
    //}

    public void AddEnergy(string amount)
    {
        //energyAmount.text = amount;


        

        if (int.TryParse(amount,out n))
        {
            //setN(value);
            //n += value;
            //n += 50;
            n += GetValue();
            energyAmount.text = amount;
            energyAmount.text = n.ToString();
            //energyAmount.text += n.ToString();
            //int o = n + int.Parse(energyAmount.text);
            //o++;


        }
    }

    public void AddEnergy2(int amount)
    {

        amount += 50;
        energyAmount.text = amount.ToString();
        
    }

    public void SetAngle(string amount)
    {
        float n;
        if(float.TryParse(amount,out n))
        {
            n *= Mathf.PI / 180.0f;
            //n *= Mathf.Deg2Rad;
            tank.transform.up = HolisticMath.Rotate(new NormalCoordinates(tank.transform.up),n,false).ToVector();
        }
    }


   
}
