using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binControl : MonoBehaviour
{
    public Transform plateObj;
    public Transform trayObj;
    public Transform pastaObj;
    public Transform marinarasauceObj;
    public Transform pestoObj;
    public Transform cheeseObj;
    public Transform hawaiianObj;
    public Transform mushroomObj;
    public Transform truffleObj;
    public Transform pepperoniObj;
    public Transform cup1Obj;
    public Transform cup2Obj;
    public Transform glassObj;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.name == "plateBin")
        {
            if (gameplay.plateholderS1 == "empty")
            {
                Instantiate(plateObj, new Vector2(-1, -.5f), plateObj.rotation);
              
                gameplay.plateholderS1 = "justplate";
                //gameplay.selectedSlot = 1;
            }
            else
                 if (gameplay.plateholderS1 == "plateBin")
            {
                Instantiate(plateObj, new Vector2(0, -.5f), plateObj.rotation);
                
                gameplay.plateholderS1 = "justplate";
                //gameplay.selectedSlot = 2;
            }

        }
    }

    void PizzaSelect ()
    {
        if (gameObject.name == "hawaiian")
        {
            if (gameplay.trayholderS1 == "empty")
            {
                Instantiate(hawaiianObj, new Vector2(-1, -.5f), hawaiianObj.rotation);

                gameplay.plateholderS1 = "hawaiian";
                //gameplay.selectedSlot = 1;
            }
            else
                 if (gameplay.trayholderS2 == "plateBin")
            {
                Instantiate(hawaiianObj, new Vector2(0, -.5f), hawaiianObj.rotation);

                gameplay.plateholderS1 = "hawaiian";
                //gameplay.selectedSlot = 2;
            }
        }
    }
}
