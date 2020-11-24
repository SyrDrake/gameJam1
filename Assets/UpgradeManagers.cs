using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManagers : MonoBehaviour
{
    #region Variable
    private float currentFuel;
    private int currentWagonWood = 1;
    private int currentWagonRock = 0;
    private int currentWagonIron = 0;

    public AchatManagers achatManagers;
    public PlayrManager playrManager;

    #endregion

    #region Button + textFeedback

    #endregion

    #region Level1Upgrade1
    private bool level1 = true;
    public float maxFuelLevel1Upgrade1 = 100;
    private bool fuelLevel1Upgrade1 = true;
    private bool chassiLevel1Upgrade1 = true;
    private bool recolteWoodLevel1Upgrade1 = true;
    private bool vitesseLevel1Upgrade1 = true;
    #endregion

    #region Level1Upgrade2
    private float maxFuelLevel1Upgrade2 = 150;
    public bool fuelLevel1Upgrade2 = false;
    public bool chassiLevel1Upgrade2 = false;
    public bool recoltWoodLeval1Upgrade2 = false;
    public bool vitesseLevel1Upgrade2 = false;
    #endregion

    #region Level2Upgrade3
    private bool level2 = false;
    public float maxFuelLevel2Upgrade3 = 200;
    public bool fuelLevel2Upgrade3 = false;
    public bool chassiLevel2Upgrade3 = false;
    public bool recolteWoodLevel2Upgrade3 = false;
    public bool recolteRockLevel2Upgrade3 = false;
    public bool vitesseLevel2Upgrade3 = false;
    #endregion

    #region Level2Upgrade4
    public float maxFuelLevel2Upgrade4 = 250;
    public bool fuelLevel2Upgrade4 = false;
    public bool chassiLevel2Upgrade4 = false;
    public bool recolteWoodLevel2Upgrade4 = false;
    public bool recolteRockLevel2Upgrade4 = false;
    public bool vitesseLevel2Upgrade4 = false;
    #endregion

    #region Level3Upgrade5
    private bool level3 = false;
    private float maxFuelLevel3Upgrade5 = 300;
    private bool fuelLevel3Upgrade5 = false;
    private bool chassiLevel3Upgrade5 = false;
    private bool recolteWoodLevel3Upgrade5 = false;
    private bool recolteRockLevel3Upgrade5 = false;
    private bool recolteIronLevel3Upgrade5 = false;
    private bool vitesseLevel3Upgrade5 = false;
    #endregion

    #region Level3Upgrade6
    public float maxFuelLevel3Upgrade6 = 350;
    public bool fuelLevel3Upgrade6 = false;
    public bool chassiLevel3Upgrade6 = false;
    public bool recolteWoodLevel3Upgrade6 = false;
    public bool recolteRockLevel3Upgrade6 = false;
    public bool recolteIronLevel3Upgrade6 = false;
    public bool vitesseLevel3Upgrade6 = false;
    #endregion




    // Start is called before the first frame update
    void Start()
    {
        currentFuel = maxFuelLevel1Upgrade1;


        achatManagers.GetComponent<AchatManagers>();
        playrManager.GetComponent<PlayrManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FuelLevel1Upgrade2()
    {
        currentFuel = maxFuelLevel1Upgrade2;
        fuelLevel1Upgrade1 = false;
        fuelLevel1Upgrade2 = true;
        

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
            Debug.Log("youCanHaveLevel2");
        }
    }

    public void ChassiLevel1Upgrade2()
    {
        chassiLevel1Upgrade2 = true;
        chassiLevel1Upgrade1 = false;
        playrManager.currentChassi = "chassiLevel1Upgrade2";

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
            Debug.Log("youCanHaveLevel2");
        }
    }

    public void RecoltWoodLevel1Upgrade2()
    {
        recolteWoodLevel1Upgrade1 = false;
        recoltWoodLeval1Upgrade2 = true;

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
            Debug.Log("youCanHaveLevel2");
        }
    }
    
    public void VitesseLevel1Upgrade2()
    {
        vitesseLevel1Upgrade1 = false;
        vitesseLevel1Upgrade2 = true;

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
            Debug.Log("youCanHaveLevel2");
        }
    }

    public void Level1ToLevel2()
    {
        if(chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            level1 = false;
            level2 = true;

            maxFuelLevel2Upgrade3 = 200;
            fuelLevel2Upgrade3 = true;
            chassiLevel2Upgrade3 = true;
            recolteWoodLevel2Upgrade3 = true;
            recolteRockLevel2Upgrade3 = true;
            vitesseLevel2Upgrade3 = true;
            playrManager.currentChassi = "chassiLevel2Upgrade3";

            currentFuel = maxFuelLevel2Upgrade3;
            fuelLevel1Upgrade2 = false;
            chassiLevel1Upgrade2 = false;
            recoltWoodLeval1Upgrade2 = false;
            vitesseLevel1Upgrade2 = false;

}
    }





    public void FuelLevel2Upgrade4()
    {
        currentFuel = maxFuelLevel2Upgrade4;
        fuelLevel2Upgrade3 = false;
        fuelLevel2Upgrade4 = true;

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            Debug.Log("youCanHaveLevel3");
        }
    }

    public void ChassiLevel2Upgrade4()
    {
        chassiLevel2Upgrade3 = false;
        chassiLevel2Upgrade4 = true;
        playrManager.currentChassi = "chassiLevel2Upgrade4";

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            Debug.Log("youCanHaveLevel3");
        }
    }

    public void RecolteWoodLevel2Upgrade4()
    {
        recolteWoodLevel2Upgrade3 = false;
        recolteWoodLevel2Upgrade4 = true;

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            Debug.Log("youCanHaveLevel3");
        }
    }

    public void RecolteRockLevel2Upgrade4()
    {
        recolteRockLevel2Upgrade3 = false;
        recolteRockLevel2Upgrade4 = true;

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            Debug.Log("youCanHaveLevel3");
        }
    }

    public void VitesseLevel2Upgrade4()
    {
        vitesseLevel2Upgrade3 = false;
        vitesseLevel2Upgrade4 = true;

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            Debug.Log("youCanHaveLevel3");
        }
    }

    public void Level2ToLevel3()
    {
        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            level2 = false;
            level3 = true;

            maxFuelLevel3Upgrade5 = 300;
            fuelLevel2Upgrade3 = false;
            chassiLevel2Upgrade3 = false;
            recolteWoodLevel2Upgrade3 = false;
            recolteRockLevel2Upgrade3 = false;
            vitesseLevel2Upgrade3 = false;

            currentFuel = maxFuelLevel3Upgrade5;
            fuelLevel3Upgrade5 = true;
            chassiLevel3Upgrade5 = true;
            recolteWoodLevel3Upgrade5 = true;
            recolteRockLevel3Upgrade5 = true;
            recolteIronLevel3Upgrade5 = true;
            vitesseLevel3Upgrade5 = true;
            playrManager.currentChassi = "chassiLevel3Upgrade5";

        }
    }




    public void FuelLevel3Upgrade6()
    {
        currentFuel = maxFuelLevel2Upgrade4;
        fuelLevel3Upgrade5 = false;
        fuelLevel3Upgrade6 = true;

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void ChassiLevel3Upgrade6()
    {
        chassiLevel3Upgrade5 = false;
        chassiLevel3Upgrade6 = true;
        playrManager.currentChassi = "chassiLevel3Upgrade6";

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void RecolteWoodLevel3Upgrade6()
    {
        recolteWoodLevel3Upgrade5 = false;
        recolteWoodLevel3Upgrade6 = true;

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void RecolteRockLevel3Upgrade6()
    {
        recolteRockLevel3Upgrade5 = false;
        recolteRockLevel3Upgrade6 = true;

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void RecolteIronLevel3Upgrade6()
    {
        recolteIronLevel3Upgrade5 = false;
        recolteIronLevel3Upgrade6 = true;

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void VitesseLevel3Upgrade6()
    {
        vitesseLevel3Upgrade5 = false;
        vitesseLevel3Upgrade6 = true;


        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }



}
