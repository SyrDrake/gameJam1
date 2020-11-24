using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManagers : MonoBehaviour
{
    public bool debug;

    private int currentBois;
    public int startBois = 0;
    public float timeRecolteBois;
    public Image recolteBois;
    private bool isRecoltingWood;
    public Text currentBoisText;
    public GameObject uiBois;

    private int currentRock;
    public int StartRock = 0;
    public float timeRecolteRock;
    public Image recolteRock;
    private bool isRecoltingRock;
    public Text currentRockText;
    public GameObject uiRock;

    private int currentIron;
    public int StartIron = 0;
    public float timeRecolteIron;
    public Image recolteIron;
    private bool isRecoltingIron;
    public Text currentIronText;

    public float currentMoney = 0;
    public Text currentMoneyText;
    public float valueBois = 0.1f;
    public float valueRock = 0.5f;
    public float valueIron = 0.7f;


    // Start is called before the first frame update
    void Start()
    {
        currentBois = startBois;
        recolteBois.enabled = false;
        isRecoltingWood = false;

        currentRock = StartRock;
        recolteRock.enabled = false;
        isRecoltingRock = false;

        currentIron = StartIron;
        recolteIron.enabled = false;
        isRecoltingIron = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
       
       

        if (isRecoltingWood)
        {
            recolteBois.fillAmount -= 1 / timeRecolteBois * Time.deltaTime;
        }

        if (isRecoltingRock)
        {
            recolteRock.fillAmount -= 1 / timeRecolteRock * Time.deltaTime;
        }

        if (isRecoltingIron)
        {
            recolteIron.fillAmount -= 1 / timeRecolteIron * Time.deltaTime;
        }



    }

    public void StartCoroutineBois()
    {
        StartCoroutine(TakeBois());
        
        
    }

    public void StartCoroutineRock()
    {
        StartCoroutine(TakeRock());

    }

    public void StartCoroutineIron()
    {
        StartCoroutine(TakeIron());

    }


    IEnumerator TakeBois()
    {
        uiBois.SetActive(true);
        recolteBois.enabled = true;
        recolteBois.fillAmount = 1;
        isRecoltingWood = true;
        yield return new WaitForSeconds(timeRecolteBois);
        currentBois += 10;
        currentBoisText.text = currentBois.ToString();
        recolteBois.enabled = false;
        isRecoltingWood = false;
        uiBois.SetActive(false);
        if (debug) Debug.Log("Bois :" + currentBois);
    }

    IEnumerator TakeRock()
    {
        uiRock.SetActive(true);
        recolteRock.enabled = true;
        recolteRock.fillAmount = 1;
        isRecoltingRock = true;
        yield return new WaitForSeconds(timeRecolteRock);
        currentRock += 7;
        currentRockText.text = currentRock.ToString();
        recolteRock.enabled = false;
        isRecoltingRock = false;
        uiRock.SetActive(false);
        if (debug) Debug.Log("Rock :" + currentRock);
    }

    IEnumerator TakeIron()
    {
        recolteIron.enabled = true;
        recolteIron.fillAmount = 1;
        isRecoltingIron = true;
        yield return new WaitForSeconds(timeRecolteIron);
        currentIron += 5;
        currentIronText.text = currentIron.ToString();
        recolteIron.enabled = false;
        isRecoltingIron = false;
        if (debug) Debug.Log("Iron :" + currentIron);
    }


    public void SaleWood()
    {
        currentMoney += currentBois * valueBois;
        currentBois = 0;
        currentBoisText.text = currentBois.ToString();
        currentMoneyText.text = currentMoney.ToString();
        if (debug) Debug.Log("Money :" + currentMoney);
    }

    public void SaleRock()
    {
        currentMoney += currentRock * valueRock;
        currentRock = 0;
        currentRockText.text = currentRock.ToString();
        currentMoneyText.text = currentMoney.ToString();
        if (debug) Debug.Log("Money :" + currentMoney);
    }

    public void SaleIron()
    {
        currentMoney += currentIron * valueIron;
        currentIron = 0;
        currentIronText.text = currentIron.ToString();
        currentMoneyText.text = currentMoney.ToString();
        if (debug) Debug.Log("Money :" + currentMoney);
    }

    public void Achat()
    {
        currentMoneyText.text = currentMoney.ToString();
    }
}
