using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchatManagers : MonoBehaviour
{
    public GameObject garageUi;
    private bool youAreLevel1 = true;
    private bool youAreLevel2 = false;
    private bool youAreLevel3 = false;
    //private bool youAreLevelMax = false;
    public bool youCanHaveLevel2 = false;
    public bool youCanHaveLevel3 = false;

    public UpgradeManagers upgradeManagers;
    public ResourceManagers resourceManagers;

    public GameObject textFeedBack_G;
    public Text textFeedBack_T;

    public GameObject textFeedBack2_G;
    public Text textFeedBack2_T;


    #region Achat Level1
    public float prixChassiLevel1Upgrade2 = 150;
    public GameObject buttonChassiLevel1Upgrade2;

    public float prixFuelLevel1Upgrade2 = 150;
    public GameObject buttonFuelLevel1Upgrade2;

    public float prixRecoltWoodLevel1Upgrade2 = 400;
    public GameObject buttonRecoltWoodLevel1Upgrade2;

    public float prixVitesseLevel1Upgrade2 = 250;
    public GameObject buttonVitesseLevel1Upgrade2;

    public float prixLevel1ToLevel2 = 1000;
    public GameObject buttonLevel1ToLevel2;
    #endregion

    #region Achat Level2
    public float prixChassiLevel2Upgrade4 = 400;
    public GameObject buttonChassiLevel2Upgrade4;

    public float prixFuelLevel2Upgrade4 = 300;
    public GameObject buttonFuelLevel2Upgrade4;

    public float prixRecolteWoodLevel2Upgrade4 = 300;
    public GameObject buttonRecolteWoodLevel2Upgrade4;

    public float prixRecolteRockLevel2Upgrade4 = 450;
    public GameObject buttonRecolteRockLevel2Upgrade4;

    public float prixVitesseLevel2Upgrade4 = 400;
    public GameObject buttonVitesseLevel2Upgrade4;

    public float prixLevel2ToLevel3 = 3000;
    public GameObject buttonLevel2ToLevel3;
    #endregion

    #region Achat Level3
    public float prixChassiLevel3Upgrade6 = 600;
    public GameObject buttonChassiLevel3Upgrade6;

    public float prixFuelLevel3Upgrade6 = 500;
    public GameObject buttonFuelLevel3Upgrade6;

    public float prixRecolteWoodLevel3Upgrade6 = 400;
    public GameObject buttonRecolteWoodLevel3Upgrade6;

    public float prixRecolteRockLevel3Upgrade6 = 500;
    public GameObject buttonRecolteRockLevel3Upgrade6;

    public float prixRecolteIronLevel3Upgrade6 = 500;
    public GameObject buttonRecolteIronLevel3Upgrade6;

    public float prixVitesseLevel3Upgrade6 = 600;
    public GameObject buttonVitesseLevel3Upgrade6;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        upgradeManagers.GetComponent<UpgradeManagers>();
        resourceManagers.GetComponent<ResourceManagers>();
        textFeedBack_G.SetActive(false);
        

        buttonChassiLevel1Upgrade2.SetActive(true);
        buttonFuelLevel1Upgrade2.SetActive(true);
        buttonRecoltWoodLevel1Upgrade2.SetActive(true);
        buttonVitesseLevel1Upgrade2.SetActive(true);

        buttonLevel2ToLevel3.SetActive(false);
        buttonLevel1ToLevel2.SetActive(false);

        buttonChassiLevel2Upgrade4.SetActive(false);
        buttonFuelLevel2Upgrade4.SetActive(false);
        buttonRecolteRockLevel2Upgrade4.SetActive(false);
        buttonRecolteWoodLevel2Upgrade4.SetActive(false);
        buttonVitesseLevel2Upgrade4.SetActive(false);

        buttonChassiLevel3Upgrade6.SetActive(false);
        buttonFuelLevel3Upgrade6.SetActive(false);
        buttonRecolteRockLevel3Upgrade6.SetActive(false);
        buttonRecolteWoodLevel3Upgrade6.SetActive(false);
        buttonRecolteIronLevel3Upgrade6.SetActive(false);
        buttonVitesseLevel3Upgrade6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(youCanHaveLevel2);
        WhatLevel();
    }

    private void WhatLevel()
    {

        if (youAreLevel1)
        {
            buttonChassiLevel1Upgrade2.SetActive(true);
            buttonFuelLevel1Upgrade2.SetActive(true);
            buttonRecoltWoodLevel1Upgrade2.SetActive(true);
            buttonVitesseLevel1Upgrade2.SetActive(true);


            buttonChassiLevel2Upgrade4.SetActive(false);
            buttonFuelLevel2Upgrade4.SetActive(false);
            buttonRecolteRockLevel2Upgrade4.SetActive(false);
            buttonRecolteWoodLevel2Upgrade4.SetActive(false);
            buttonVitesseLevel2Upgrade4.SetActive(false);
        }

        if (youAreLevel2)
        {
            buttonChassiLevel1Upgrade2.SetActive(false);
            buttonFuelLevel1Upgrade2.SetActive(false);
            buttonRecoltWoodLevel1Upgrade2.SetActive(false);
            buttonVitesseLevel1Upgrade2.SetActive(false);
            

            buttonChassiLevel2Upgrade4.SetActive(true);
            buttonFuelLevel2Upgrade4.SetActive(true);
            buttonRecolteRockLevel2Upgrade4.SetActive(true);
            buttonRecolteWoodLevel2Upgrade4.SetActive(true);
            buttonVitesseLevel2Upgrade4.SetActive(true);
        }

        if (youAreLevel3)
        {
            buttonChassiLevel3Upgrade6.SetActive(true);
            buttonFuelLevel3Upgrade6.SetActive(true);
            buttonRecolteRockLevel3Upgrade6.SetActive(true);
            buttonRecolteWoodLevel3Upgrade6.SetActive(true);
            buttonRecolteIronLevel3Upgrade6.SetActive(true);
            buttonVitesseLevel3Upgrade6.SetActive(true);


            buttonChassiLevel2Upgrade4.SetActive(false);
            buttonFuelLevel2Upgrade4.SetActive(false);
            buttonRecolteRockLevel2Upgrade4.SetActive(false);
            buttonRecolteWoodLevel2Upgrade4.SetActive(false);
            buttonVitesseLevel2Upgrade4.SetActive(false);
        }
        
    }
    public void Close()
    {
        garageUi.SetActive(false);
    }
    IEnumerator TextFeedBack()
    {
        textFeedBack_G.SetActive(true);
        yield return new WaitForSeconds(2);
        textFeedBack_G.SetActive(false);
    }

    IEnumerator TextFeedBack2()
    {
        textFeedBack2_G.SetActive(true);
        yield return new WaitForSeconds(2);
        textFeedBack2_G.SetActive(false);
    }


    public void AchatChassiLevel1Upgrade2()
    {
        if(upgradeManagers.chassiLevel1Upgrade2 == false)
        {
            if (resourceManagers.currentMoney >= prixChassiLevel1Upgrade2)
            {
                upgradeManagers.ChassiLevel1Upgrade2();
                resourceManagers.currentMoney -= prixChassiLevel1Upgrade2;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Chassi Upgrade 2 unlocked";
                buttonChassiLevel1Upgrade2.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixChassiLevel1Upgrade2)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixChassiLevel1Upgrade2;
            }
        }

        if (upgradeManagers.chassiLevel1Upgrade2 == true)
        {

        }


    }

    public void AchatFuelLevel1Upgrade2()
    {
        if (upgradeManagers.fuelLevel1Upgrade2 == false)
        {
            if (resourceManagers.currentMoney >= prixFuelLevel1Upgrade2)
            {
                upgradeManagers.FuelLevel1Upgrade2();
                resourceManagers.currentMoney -= prixFuelLevel1Upgrade2;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Fuel Upgrade 2 unlocked";
                buttonFuelLevel1Upgrade2.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixFuelLevel1Upgrade2)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixFuelLevel1Upgrade2;
            }
        }

        if (upgradeManagers.fuelLevel1Upgrade2 == true)
        {

        }

    }

    public void AchatRecoltWoodLevel1Upgrade2()
    {
        if (upgradeManagers.recoltWoodLeval1Upgrade2 == false)
        {
            if (resourceManagers.currentMoney >= prixRecoltWoodLevel1Upgrade2)
            {
                upgradeManagers.RecoltWoodLevel1Upgrade2();
                resourceManagers.currentMoney -= prixRecoltWoodLevel1Upgrade2;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Recolt Wood Upgrade 2 unlocked";
                buttonRecoltWoodLevel1Upgrade2.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixFuelLevel1Upgrade2)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixRecoltWoodLevel1Upgrade2;
            }
        }

        if (upgradeManagers.recoltWoodLeval1Upgrade2 == true)
        {

        }
    }

    public void AchatVitesseLevel1Upgrade2()
    {
        if (upgradeManagers.vitesseLevel1Upgrade2 == false)
        {
            if (resourceManagers.currentMoney >= prixVitesseLevel1Upgrade2)
            {
                upgradeManagers.VitesseLevel1Upgrade2();
                resourceManagers.currentMoney -= prixVitesseLevel1Upgrade2;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Vitesse Upgrade 2 unlocked";
                buttonVitesseLevel1Upgrade2.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixFuelLevel1Upgrade2)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixVitesseLevel1Upgrade2;
            }
        }

        if (upgradeManagers.vitesseLevel1Upgrade2 == true)
        {

        }

    }

    public void YoucanHaveLevel2()
    {
        if (youCanHaveLevel2)
        {
            buttonLevel1ToLevel2.SetActive(true);
        }
    }
    public void AcahtLevel1ToLevel2()
    {
        if(youCanHaveLevel2 == true)
        {            

            if (resourceManagers.currentMoney >= prixLevel1ToLevel2)
            {
                upgradeManagers.Level1ToLevel2();
                resourceManagers.currentMoney -= prixLevel1ToLevel2;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Congratulations you are level2";
                buttonLevel1ToLevel2.SetActive(false);
                youAreLevel2 = true;
            }

            if (resourceManagers.currentMoney < prixLevel1ToLevel2)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixLevel1ToLevel2;
            }
        }

    }





    public void AchatChassiLevel2Upgrade4()
    {
        if (upgradeManagers.chassiLevel2Upgrade4 == false)
        {
            if (resourceManagers.currentMoney >= prixChassiLevel2Upgrade4)
            {
                upgradeManagers.ChassiLevel2Upgrade4();
                resourceManagers.currentMoney -= prixChassiLevel2Upgrade4;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Chassi Upgrade 4 unlocked";
                buttonChassiLevel2Upgrade4.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixChassiLevel2Upgrade4)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixChassiLevel2Upgrade4;
            }
        }

        if (upgradeManagers.chassiLevel2Upgrade4 == true)
        {

        }


    }

    public void AchatFuelLevel2Upgrade4()
    {
        if (upgradeManagers.fuelLevel2Upgrade4 == false)
        {
            if (resourceManagers.currentMoney >= prixFuelLevel2Upgrade4)
            {
                upgradeManagers.FuelLevel2Upgrade4();
                resourceManagers.currentMoney -= prixFuelLevel2Upgrade4;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Fuel Upgrade 4 unlocked";
                buttonFuelLevel2Upgrade4.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixFuelLevel2Upgrade4)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixFuelLevel2Upgrade4;
            }
        }

        if (upgradeManagers.fuelLevel2Upgrade4 == true)
        {

        }


    }

    public void AchatRecolteWoodLevel2Upgrade4()
    {
        if (upgradeManagers.recolteWoodLevel2Upgrade4 == false)
        {
            if (resourceManagers.currentMoney >= prixRecolteWoodLevel2Upgrade4)
            {
                upgradeManagers.RecolteWoodLevel2Upgrade4();
                resourceManagers.currentMoney -= prixRecolteWoodLevel2Upgrade4;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Recolte Wood Upgrade 4 unlocked";
                buttonRecolteWoodLevel2Upgrade4.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixRecolteWoodLevel2Upgrade4)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixRecolteWoodLevel2Upgrade4;
            }
        }

        if (upgradeManagers.recolteWoodLevel2Upgrade4 == true)
        {

        }

    }

    public void AchatRecolteRockLevel2Upgrade4()
    {
        if (upgradeManagers.recolteRockLevel2Upgrade4 == false)
        {
            if (resourceManagers.currentMoney >= prixRecolteRockLevel2Upgrade4)
            {
                upgradeManagers.RecolteRockLevel2Upgrade4();
                resourceManagers.currentMoney -= prixRecolteRockLevel2Upgrade4;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Recolte Rock Upgrade 4 unlocked";
                buttonRecolteRockLevel2Upgrade4.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixRecolteRockLevel2Upgrade4)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixRecolteRockLevel2Upgrade4;
            }
        }

        if (upgradeManagers.recolteRockLevel2Upgrade4 == true)
        {

        }


    }

    public void AchatVitesseLevel2Upgrade4()
    {
        if (upgradeManagers.vitesseLevel2Upgrade4 == false)
        {
            if (resourceManagers.currentMoney >= prixVitesseLevel2Upgrade4)
            {
                upgradeManagers.VitesseLevel2Upgrade4();
                resourceManagers.currentMoney -= prixVitesseLevel2Upgrade4;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Vitesse Upgrade 4 unlocked";
                buttonVitesseLevel2Upgrade4.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixVitesseLevel2Upgrade4)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixVitesseLevel2Upgrade4;
            }
        }

        if (upgradeManagers.vitesseLevel2Upgrade4 == true)
        {

        }

    }

    public void YoucanHaveLevel3()
    {
        if (youCanHaveLevel3)
        {
            buttonLevel2ToLevel3.SetActive(true);
        }
    }

    public void AchatLevel2ToLevel3()
    {
        if (youCanHaveLevel3 == true)
        {

            if (resourceManagers.currentMoney >= prixLevel2ToLevel3)
            {
                upgradeManagers.Level2ToLevel3();
                resourceManagers.currentMoney -= prixLevel2ToLevel3;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Congratulations you are level3";
                buttonLevel2ToLevel3.SetActive(false);
                youAreLevel3 = true;
            }

            if (resourceManagers.currentMoney < prixLevel2ToLevel3)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixLevel2ToLevel3;
            }
        }

    }




    public void AchatChassiLevel3Upgrade6()
    {
        if (upgradeManagers.chassiLevel3Upgrade6 == false)
        {
            if (resourceManagers.currentMoney >= prixChassiLevel3Upgrade6)
            {
                upgradeManagers.ChassiLevel3Upgrade6();
                resourceManagers.currentMoney -= prixChassiLevel3Upgrade6;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Chassi Upgrade 6 unlocked";
                buttonChassiLevel3Upgrade6.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixChassiLevel3Upgrade6)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixChassiLevel3Upgrade6;
            }
        }

        if (upgradeManagers.chassiLevel3Upgrade6 == true)
        {
            LevelMax();
        }


    }

    public void AchatFuelLevel3Upgrade6()
    {
        if (upgradeManagers.fuelLevel3Upgrade6 == false)
        {
            if (resourceManagers.currentMoney >= prixFuelLevel3Upgrade6)
            {
                upgradeManagers.FuelLevel3Upgrade6();
                resourceManagers.currentMoney -= prixFuelLevel3Upgrade6;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Fuel Upgrade 6 unlocked";
                buttonFuelLevel3Upgrade6.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixFuelLevel3Upgrade6)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixFuelLevel3Upgrade6;
            }
        }

        if (upgradeManagers.fuelLevel3Upgrade6 == true)
        {
            LevelMax();
        }


    }

    public void AchatRecolteWoodLevel3Upgrad6()
    {
        if (upgradeManagers.recolteWoodLevel3Upgrade6 == false)
        {
            if (resourceManagers.currentMoney >= prixRecolteWoodLevel3Upgrade6)
            {
                upgradeManagers.RecolteWoodLevel3Upgrade6();
                resourceManagers.currentMoney -= prixRecolteWoodLevel3Upgrade6;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Recolte Wood Upgrade 6 unlocked";
                buttonRecolteWoodLevel3Upgrade6.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixRecolteWoodLevel3Upgrade6)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixRecolteWoodLevel3Upgrade6;
            }
        }

        if (upgradeManagers.recolteWoodLevel3Upgrade6 == true)
        {
            LevelMax();
        }

    }


    public void AchatRecolteRockLevel3Upgrade6()
    {
        if (upgradeManagers.recolteRockLevel3Upgrade6 == false)
        {
            if (resourceManagers.currentMoney >= prixRecolteRockLevel3Upgrade6)
            {
                upgradeManagers.RecolteRockLevel3Upgrade6();
                resourceManagers.currentMoney -= prixRecolteRockLevel3Upgrade6;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Recolte Rock Upgrade 6 unlocked";
                buttonRecolteRockLevel3Upgrade6.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixRecolteRockLevel3Upgrade6)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixRecolteRockLevel3Upgrade6;
            }
        }

        if (upgradeManagers.recolteRockLevel3Upgrade6 == true)
        {
            LevelMax();
        }


    }

    public void AchatRecolteIronLevel3Upgrade6()
    {
        if (upgradeManagers.recolteIronLevel3Upgrade6 == false)
        {
            if (resourceManagers.currentMoney >= prixRecolteIronLevel3Upgrade6)
            {
                upgradeManagers.RecolteIronLevel3Upgrade6();
                resourceManagers.currentMoney -= prixRecolteIronLevel3Upgrade6;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Recolte Iron Upgrade 6 unlocked";
                buttonRecolteIronLevel3Upgrade6.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixRecolteIronLevel3Upgrade6)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixRecolteIronLevel3Upgrade6;
            }
        }

        if (upgradeManagers.recolteIronLevel3Upgrade6 == true)
        {
            LevelMax();
        }


    }

    public void AchatVitesseLevel3Upgrade6()
    {
        if (upgradeManagers.vitesseLevel3Upgrade6 == false)
        {
            if (resourceManagers.currentMoney >= prixVitesseLevel3Upgrade6)
            {
                upgradeManagers.VitesseLevel3Upgrade6();
                resourceManagers.currentMoney -= prixVitesseLevel3Upgrade6;
                resourceManagers.Achat();
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Vitesse Upgrade 6 unlocked";
                buttonVitesseLevel3Upgrade6.SetActive(false);
            }

            if (resourceManagers.currentMoney < prixVitesseLevel3Upgrade6)
            {
                StartCoroutine(TextFeedBack());
                textFeedBack_T.text = "Not enough money ! To have it you need " + prixVitesseLevel3Upgrade6;
            }
        }

        if (upgradeManagers.vitesseLevel3Upgrade6 == true)
        {
            LevelMax();
        }

    }

    public void LevelMax()
    {
        StartCoroutine(TextFeedBack());
        textFeedBack_T.text = "You are Level Max !!";
    }


}





