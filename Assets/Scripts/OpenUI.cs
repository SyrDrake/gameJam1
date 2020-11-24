using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public GameObject garageUI;

    // Start is called before the first frame update
    void Start()
    {
        garageUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            garageUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        garageUI.SetActive(false);
    }
}
