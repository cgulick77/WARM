using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreUi : MonoBehaviour
{
    private Inputs inputs;
    public GameObject uiActivaorId;
    public GameObject Indicator_1, Indicator_2, Indicator_3;
    private bool UiOn;
    // Start is called before the first frame update
    void Start()
    {
        inputs = GetComponent<Inputs>();
        SetIndicatorsOff();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputs.shipActions.OpenShipUi.triggered)
        {
            if(uiActivaorId.activeSelf)
            {
                 uiActivaorId.SetActive(false);
                 UiOn = true;
            }
            else
            {
                 uiActivaorId.SetActive(true);
                 UiOn = false;
                 SetIndicatorsOff();
            }
           
        }

        if(UiOn == true)
        {
            if(inputs.shipActions.UiOre1.triggered)
        {
                if(Indicator_1.activeSelf)
                {
                    Indicator_1.SetActive(false);
                }
                else
                {
                    Indicator_1.SetActive(true);
                    Indicator_2.SetActive(false);
                    Indicator_3.SetActive(false);
                }
        }
        if(inputs.shipActions.UiOre2.triggered)
        {
                if(Indicator_2.activeSelf)
                {
                    Indicator_2.SetActive(false);
                }
                else
                {
                    Indicator_2.SetActive(true);
                    Indicator_1.SetActive(false);
                    Indicator_3.SetActive(false);
                }
        }
        if(inputs.shipActions.UiOre3.triggered)
        {
                if(Indicator_3.activeSelf)
                {
                    Indicator_3.SetActive(false);
                }
                else
                {
                    Indicator_3.SetActive(true);
                    Indicator_2.SetActive(false);
                    Indicator_1.SetActive(false);
                }
        }
        }

       
       
        
    }
     void SetIndicatorsOff()
        {
            Indicator_1.SetActive(false);
            Indicator_2.SetActive(false);
            Indicator_3.SetActive(false);
        }
}
