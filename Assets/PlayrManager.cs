using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrManager : MonoBehaviour
{
    public ResourceManagers resourceManagers;
    public Mover mover;

    public int currentWagonWood = 0;
    public int currentWagonRock = 0;
    public int currentWagonIron = 0;
    public string currentChassi;
    public string currentFuel;
    public string currentRecolteWood;
    public string currentRecolteRock;
    public string currentRecolteIron;
    public string currentVitesse;

    private int maxWood_PM;
    private int maxRock_PM;
    private int maxIron_PM;
    public int maxFuel_PM;
    


    // Start is called before the first frame update
    void Start()
    {
        resourceManagers.GetComponent<ResourceManagers>();
        mover.GetComponent<Mover>();

        currentChassi = "chassiLevel1Upgrade1";
        currentFuel = "currentFuel";
        currentRecolteWood = "recolteWoodLevel1Upgrade1";
        currentRecolteRock = "no";
        currentRecolteIron = "no";
        currentVitesse = "vitesseLevel1Upgrade1";

        maxFuel_PM = 150;

        ChassiUpgrade();
        WagonUpgrade();

    }

    // Update is called once per frame
    void Update()
    {

    }

    #region Chassi
    public void ChassiUpgrade()
    {
        if(currentChassi == "chassiLevel1Upgrade1")
        {
            currentWagonWood = 1;
            currentWagonRock = 0;
            currentWagonIron = 0;

        }

        if (currentChassi == "chassiLevel1Upgrade2")
        {
            currentWagonWood = 2;
            currentWagonRock = 0;
            currentWagonIron = 0;
        }

        if (currentChassi == "chassiLevel2Upgrade3")
        {
            currentWagonWood = 3;
            currentWagonRock = 1;
            currentWagonIron = 0;
        }

        if (currentChassi == "chassiLevel2Upgrade4")
        {
            currentWagonWood = 4;
            currentWagonRock = 2;
            currentWagonIron = 0;
        }

        if (currentChassi == "chassiLevel3Upgrade5")
        {
            currentWagonWood = 5;
            currentWagonRock = 3;
            currentWagonIron = 1;
        }

        if (currentChassi == "chassiLevel3Upgrade6")
        {
            currentWagonWood = 6;
            currentWagonRock = 4;
            currentWagonIron = 2;
        }
    }
    #endregion

    #region Wagon
    public void WagonUpgrade()
    {

        #region WogonWood
        if (currentWagonWood == 1)
        {
            
            maxWood_PM = 150;


        }

        if (currentWagonWood == 2)
        {
            maxWood_PM = 250;
            
        }

        if (currentWagonWood == 3)
        {
            maxWood_PM = 400;
            
        }

        if (currentWagonWood == 4)
        {
            maxWood_PM = 600;
            
        }

        if (currentWagonWood == 5)
        {
            maxWood_PM = 750;
           
        }

        if (currentWagonWood == 6)
        {
            maxWood_PM = 1000;
           
        }
        #endregion


        #region WagonRock
        if (currentWagonRock == 0)
        {
            maxRock_PM = 0;
            resourceManagers.maxWood_RM = maxRock_PM;
        }

        if (currentWagonRock == 1)
        {
            maxRock_PM = 100;
            resourceManagers.maxWood_RM = maxRock_PM;
        }

        if (currentWagonRock == 2)
        {
            maxRock_PM = 200;
            resourceManagers.maxWood_RM = maxRock_PM;
        }

        if (currentWagonRock == 3)
        {
            maxRock_PM = 300;
            resourceManagers.maxWood_RM = maxRock_PM;
        }

        if (currentWagonRock == 4)
        {
            maxRock_PM = 500;
            resourceManagers.maxWood_RM = maxRock_PM;
        }
        #endregion


        #region WagonIron
        if (currentWagonIron == 0)
        {
            maxIron_PM = 0;
            resourceManagers.maxIron_RM = maxIron_PM;
        }

        if (currentWagonIron == 1)
        {
            maxIron_PM = 150;
            resourceManagers.maxIron_RM = maxIron_PM;
        }

        if (currentWagonIron == 2)
        {
            maxIron_PM = 300;
            resourceManagers.maxIron_RM = maxIron_PM;
        }
        #endregion
        resourceManagers.maxWood_RM = maxWood_PM;
        resourceManagers.maxRock_RM = maxRock_PM;
        resourceManagers.maxIron_RM = maxIron_PM;
        //Debug.Log(resourceManagers.maxWood_RM);
    }

    public void FuelUpgrade()
    {
        if (currentFuel == "fuelLevel1Upgrade2")
        {
            maxFuel_PM = 200;
        }

        if (currentFuel == "fuelLevel2Upgrade3")
        {
            maxFuel_PM = 250;
        }

        if (currentFuel == "fuelLevel2Upgrade4")
        {
            maxFuel_PM = 300;
        }

        if (currentFuel == "fuelLevel3Upgrade5")
        {
            maxFuel_PM = 350;
        }

        if (currentFuel == "fuelLevel3Upgrade6")
        {
            maxFuel_PM = 400;
        }
    }
    #endregion

    public void RecolteWoodUpgrade()
    {
        if(currentRecolteWood == "recolteWoodLevel1Upgrade2")
        {
            resourceManagers.timeRecolteBois = 0.6f;
        }

        if (currentRecolteWood == "recolteWoodLevel2Upgrade3")
        {
            resourceManagers.timeRecolteBois = 0.5f;
        }

        if (currentRecolteWood == "recolteWoodLevel2Upgrade4")
        {
            resourceManagers.timeRecolteBois = 0.4f;
        }

        if (currentRecolteWood == "recolteWoodLevel3Upgrade5")
        {
            resourceManagers.timeRecolteBois = 0.2f;
        }

        if (currentRecolteWood == "recolteWoodLevel3Upgrade6")
        {
            resourceManagers.timeRecolteBois = 0.1f;
        }
    }

    public void RecolteRockUpgrade()
    {
        if (currentRecolteRock == "recolteRockLevel2Upgrade4")
        {
            resourceManagers.timeRecolteRock = 0.8f;
        }

        if (currentRecolteRock == "recolteRockLevel3Upgrade5")
        {
            resourceManagers.timeRecolteRock = 0.6f;
        }

        if (currentRecolteRock == "recolteRockLevel3Upgrade6")
        {
            resourceManagers.timeRecolteRock = 0.4f;
        }
    }

    public void RecolteIronUpgrade()
    {
        if (currentRecolteIron == "recolteIronLevel3Upgrade6")
        {
            resourceManagers.timeRecolteIron = 6;
        }
    }

    public void VitesseUpgrade()
    {
        if (currentVitesse == "vitesseLevel1Upgrade1")
        {
            mover.speed = 4;
            Debug.Log(mover.speed);
        }

        if (currentVitesse == "vitesseLevel1Upgrade2")
        {
            mover.speed = 5;
        }

        if (currentVitesse == "vitesseLevel2Upgrade3")
        {
            mover.speed = 6;
        }

        if (currentVitesse == "vitesseLevel2Upgrade4")
        {
            mover.speed = 7;
        }

        if (currentVitesse == "vitesseLevel3Upgrade5")
        {
            mover.speed = 8;
        }

        if (currentVitesse == "vitesseLevel3Upgrade5")
        {
            mover.speed = 9;
        }
    }
}
