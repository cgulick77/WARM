using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreUi : MonoBehaviour
{
    private Inputs inputs;
    public GameObject uiActivaorId;
    public GameObject Indicator_1, Indicator_2, Indicator_3;
    private bool UiOn;
    private PlayerMaterialManager playerMaterialManager;
    // Start is called before the first frame update
    void Start()
    {
        inputs = GetComponent<Inputs>();
        playerMaterialManager = GetComponent<PlayerMaterialManager>();
        SetIndicatorsOff();
    }

    // Update is called once per frame
    void Update()
    {
        //UI Activator
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
            //Ore one checker
            if(inputs.shipActions.UiOre1.triggered)
        {
                if(Indicator_1.activeSelf)
                {
                    Indicator_1.SetActive(false);
                }
                else
                {
                    SetIndicators(true,false,false);
                    playerMaterialManager.RefineOre("FirstOre");
                    Debug.Log("RefineFirstOre");
                }
        }
        //Ore two checker
        if(inputs.shipActions.UiOre2.triggered)
        {
                if(Indicator_2.activeSelf)
                {
                    Indicator_2.SetActive(false);
                }
                else
                {
                    SetIndicators(false,true,false);
                }
        }
        //Ore three chekcer
        if(inputs.shipActions.UiOre3.triggered)
        {
                if(Indicator_3.activeSelf)
                {
                    Indicator_3.SetActive(false);
                }
                else
                {
                    SetIndicators(false,false,true);
                }
        }
        }

       
       
        
    }

    //Turns off all the indicators
     void SetIndicatorsOff()
        {
            Indicator_1.SetActive(false);
            Indicator_2.SetActive(false);
            Indicator_3.SetActive(false);
        }

    //Sets Indicators active or inactive
    void SetIndicators(bool Ind1, bool Ind2, bool Ind3)
    {
        Indicator_1.SetActive(Ind1);
        Indicator_2.SetActive(Ind2);
        Indicator_3.SetActive(Ind3);
    }
    
}
