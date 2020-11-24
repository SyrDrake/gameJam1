using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrManager : MonoBehaviour
{
    public ResourceManagers resourceManagers;


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
    


    // Start is called before the first frame update
    void Start()
    {
        resourceManagers = GetComponent<ResourceManagers>();

        currentChassi = "chassiLevel1Upgrade1";
        currentFuel = "currentFuel";
        currentRecolteWood = "recolteWoodLevel1Upgrade1";
        currentRecolteRock = "no";
        currentRecolteIron = "no";
        currentVitesse = "vitesseLevel1Upgrade1";
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
        
        if(currentWagonWood == 1)
        {
            maxWood_PM = 150;
            resourceManagers.maxWood_RM = maxWood_PM;
        }

        if (currentWagonWood == 2)
        {
            maxWood_PM = 250;
            resourceManagers.maxWood_RM = maxWood_PM;
        }

        if (currentWagonWood == 3)
        {
            maxWood_PM = 400;
            resourceManagers.maxWood_RM = maxWood_PM;
        }

        if (currentWagonWood == 4)
        {
            maxWood_PM = 600;
            resourceManagers.maxWood_RM = maxWood_PM;
        }

        if (currentWagonWood == 5)
        {
            maxWood_PM = 750;
            resourceManagers.maxWood_RM = maxWood_PM;
        }

        if (currentWagonWood == 6)
        {
            maxWood_PM = 1000;
            resourceManagers.maxWood_RM = maxWood_PM;
        }




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
    }
    #endregion
}
