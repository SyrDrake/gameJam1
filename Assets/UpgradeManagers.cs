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

    public Image fillFuel;

    public AchatManagers achatManagers;
    public PlayrManager playrManager;

    #endregion

    #region Button + textFeedback

    #endregion

    #region Level1Upgrade1
    private bool level1 = true;
    public float maxFuelLevel1Upgrade1 = 150;
    private bool fuelLevel1Upgrade1 = true;
    private bool chassiLevel1Upgrade1 = true;
    private bool recolteWoodLevel1Upgrade1 = true;
    private bool vitesseLevel1Upgrade1 = true;
    #endregion

    #region Level1Upgrade2
    public bool fuelLevel1Upgrade2 = false;
    public bool chassiLevel1Upgrade2 = false;
    public bool recoltWoodLeval1Upgrade2 = false;
    public bool vitesseLevel1Upgrade2 = false;
    #endregion

    #region Level2Upgrade3
    private bool level2 = false;
    public bool fuelLevel2Upgrade3 = false;
    public bool chassiLevel2Upgrade3 = false;
    public bool recolteWoodLevel2Upgrade3 = false;
    public bool recolteRockLevel2Upgrade3 = false;
    public bool vitesseLevel2Upgrade3 = false;
    #endregion

    #region Level2Upgrade4
    
    public bool fuelLevel2Upgrade4 = false;
    public bool chassiLevel2Upgrade4 = false;
    public bool recolteWoodLevel2Upgrade4 = false;
    public bool recolteRockLevel2Upgrade4 = false;
    public bool vitesseLevel2Upgrade4 = false;
    #endregion

    #region Level3Upgrade5
    private bool level3 = false;

    private bool fuelLevel3Upgrade5 = false;
    private bool chassiLevel3Upgrade5 = false;
    private bool recolteWoodLevel3Upgrade5 = false;
    private bool recolteRockLevel3Upgrade5 = false;
    private bool recolteIronLevel3Upgrade5 = false;
    private bool vitesseLevel3Upgrade5 = false;
    #endregion

    #region Level3Upgrade6

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

        playrManager.currentVitesse = "vitesseLevel1Upgrade1";
        playrManager.VitesseUpgrade();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Fuel :" + currentFuel);
        if (Input.GetButton("Vertical"))
        {
            currentFuel -= 0.1f;
            currentFuel = Mathf.Clamp(currentFuel, 0, 5000);
            fillFuel.fillAmount -= playrManager.maxFuel_PM / 100;
        }
    }

    public void FuelLevel1Upgrade2()
    {
        //currentFuel = maxFuelLevel1Upgrade2;
        fuelLevel1Upgrade1 = false;
        fuelLevel1Upgrade2 = true;
        playrManager.currentFuel = "fuelLevel1Upgrade2";
        playrManager.FuelUpgrade();
        currentFuel = playrManager.maxFuel_PM;
        

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
            
        }
    }

    public void ChassiLevel1Upgrade2()
    {
        chassiLevel1Upgrade2 = true;
        chassiLevel1Upgrade1 = false;
        playrManager.currentChassi = "chassiLevel1Upgrade2";
        playrManager.ChassiUpgrade();
        playrManager.WagonUpgrade();

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
            
        }
    }

    public void RecoltWoodLevel1Upgrade2()
    {
        recolteWoodLevel1Upgrade1 = false;
        recoltWoodLeval1Upgrade2 = true;
        playrManager.currentRecolteWood = "recolteWoodLevel1Upgrade2";
        playrManager.RecolteWoodUpgrade();

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
        }
    }
    
    public void VitesseLevel1Upgrade2()
    {
        vitesseLevel1Upgrade1 = false;
        vitesseLevel1Upgrade2 = true;
        playrManager.currentVitesse = "vitesseLevel1Upgrade2";
        playrManager.VitesseUpgrade();

        if (chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            achatManagers.youCanHaveLevel2 = true;
            achatManagers.YoucanHaveLevel2();
      
        }
    }

    public void Level1ToLevel2()
    {
        if(chassiLevel1Upgrade2 == true && recoltWoodLeval1Upgrade2 == true && vitesseLevel1Upgrade2 == true && fuelLevel1Upgrade2 == true)
        {
            level1 = false;
            level2 = true;

       
            fuelLevel2Upgrade3 = true;
            chassiLevel2Upgrade3 = true;
            recolteWoodLevel2Upgrade3 = true;
            recolteRockLevel2Upgrade3 = true;
            vitesseLevel2Upgrade3 = true;
            playrManager.currentChassi = "chassiLevel2Upgrade3";
            playrManager.ChassiUpgrade();
            playrManager.WagonUpgrade();

            playrManager.currentFuel = "fuelLevel2Upgrade3";
            playrManager.FuelUpgrade();
            currentFuel = playrManager.maxFuel_PM;

            playrManager.currentRecolteWood = "recolteWoodLevel2Upgrade3";
            playrManager.RecolteWoodUpgrade();

            playrManager.currentVitesse = "vitesseLevel2Upgrade3";
            playrManager.VitesseUpgrade();


           
            fuelLevel1Upgrade2 = false;
            chassiLevel1Upgrade2 = false;
            recoltWoodLeval1Upgrade2 = false;
            vitesseLevel1Upgrade2 = false;

}
    }





    public void FuelLevel2Upgrade4()
    {
       
        fuelLevel2Upgrade3 = false;
        fuelLevel2Upgrade4 = true;
        playrManager.currentFuel = "fuelLevel2Upgrade4";
        playrManager.FuelUpgrade();
        currentFuel = playrManager.maxFuel_PM;

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
        
        }
    }

    public void ChassiLevel2Upgrade4()
    {
        chassiLevel2Upgrade3 = false;
        chassiLevel2Upgrade4 = true;
        playrManager.currentChassi = "chassiLevel2Upgrade4";
        playrManager.ChassiUpgrade();
        playrManager.WagonUpgrade();

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
          
        }
    }

    public void RecolteWoodLevel2Upgrade4()
    {
        recolteWoodLevel2Upgrade3 = false;
        recolteWoodLevel2Upgrade4 = true;
        playrManager.currentRecolteWood = "recolteWoodLevel2Upgrade4";
        playrManager.RecolteWoodUpgrade();


        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            
        }
    }

    public void RecolteRockLevel2Upgrade4()
    {
        recolteRockLevel2Upgrade3 = false;
        recolteRockLevel2Upgrade4 = true;
        playrManager.currentRecolteRock = "recolteRockLevel2Upgrade4";
        playrManager.RecolteRockUpgrade();

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
            
        }
    }

    public void VitesseLevel2Upgrade4()
    {
        vitesseLevel2Upgrade3 = false;
        vitesseLevel2Upgrade4 = true;
        playrManager.currentVitesse = "vitesseLevel2Upgrade4";
        playrManager.VitesseUpgrade();

        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            achatManagers.youCanHaveLevel3 = true;
            achatManagers.YoucanHaveLevel3();
           
        }
    }

    public void Level2ToLevel3()
    {
        if (chassiLevel2Upgrade4 == true && recolteWoodLevel2Upgrade4 == true && recolteRockLevel2Upgrade4 == true && vitesseLevel2Upgrade4 == true && fuelLevel2Upgrade4 == true)
        {
            level2 = false;
            level3 = true;

     
            fuelLevel2Upgrade3 = false;
            chassiLevel2Upgrade3 = false;
            recolteWoodLevel2Upgrade3 = false;
            recolteRockLevel2Upgrade3 = false;
            vitesseLevel2Upgrade3 = false;

            fuelLevel3Upgrade5 = true;
            chassiLevel3Upgrade5 = true;
            recolteWoodLevel3Upgrade5 = true;
            recolteRockLevel3Upgrade5 = true;
            recolteIronLevel3Upgrade5 = true;
            vitesseLevel3Upgrade5 = true;
            playrManager.currentChassi = "chassiLevel3Upgrade5";
            playrManager.ChassiUpgrade();
            playrManager.WagonUpgrade();

            playrManager.currentFuel = "fuelLevel3Upgrade5";
            playrManager.FuelUpgrade();
            currentFuel = playrManager.maxFuel_PM;

            playrManager.currentRecolteWood = "recolteWoodLevel3Upgrade5";
            playrManager.RecolteWoodUpgrade();

            playrManager.currentRecolteRock = "recolteRockLevel3Upgrade5";
            playrManager.RecolteRockUpgrade();

            playrManager.currentVitesse = "vitesseLevel3Upgrade5";
            playrManager.VitesseUpgrade();


        }
    }




    public void FuelLevel3Upgrade6()
    {
        
        fuelLevel3Upgrade5 = false;
        fuelLevel3Upgrade6 = true;
        playrManager.currentFuel = "fuelLevel3Upgrade6";
        playrManager.FuelUpgrade();
        currentFuel = playrManager.maxFuel_PM;

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
        playrManager.ChassiUpgrade();
        playrManager.WagonUpgrade();

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void RecolteWoodLevel3Upgrade6()
    {
        recolteWoodLevel3Upgrade5 = false;
        recolteWoodLevel3Upgrade6 = true;
        playrManager.currentRecolteWood = "recolteWoodLevel3Upgrade6";
        playrManager.RecolteWoodUpgrade();


        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void RecolteRockLevel3Upgrade6()
    {
        recolteRockLevel3Upgrade5 = false;
        recolteRockLevel3Upgrade6 = true;
        playrManager.currentRecolteRock = "recolteRockLevel3Upgrade6";
        playrManager.RecolteRockUpgrade();

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void RecolteIronLevel3Upgrade6()
    {
        recolteIronLevel3Upgrade5 = false;
        recolteIronLevel3Upgrade6 = true;
        playrManager.currentRecolteIron = "recolteIronLevel3Upgrade6";
        playrManager.RecolteIronUpgrade();

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }

    public void VitesseLevel3Upgrade6()
    {
        vitesseLevel3Upgrade5 = false;
        vitesseLevel3Upgrade6 = true;
        playrManager.currentVitesse = "vitesseLevel3Upgrade6";
        playrManager.VitesseUpgrade();

        if (chassiLevel3Upgrade6 == true && recolteWoodLevel3Upgrade6 == true && recolteRockLevel3Upgrade6 == true && recolteIronLevel3Upgrade6 == true && vitesseLevel3Upgrade6 == true && fuelLevel3Upgrade6 == true)
        {
            achatManagers.LevelMax();
        }
    }



}
