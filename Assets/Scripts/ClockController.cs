using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{

    public GameObject hourHand;

    public GameObject minHand;

    public GameObject secHand;

    // Update is called once per frame
    void Update()
    {
        UpdateHourHand();
    }

    void UpdateHourHand()
    {
        hourHand.transform.localRotation = Quaternion.Euler((DateTime.Now.Hour) * 360f / 12, 0, 0);
        minHand.transform.localRotation = Quaternion.Euler((DateTime.Now.Minute) * 360 / 60, 0, 0);
        secHand.transform.localRotation = Quaternion.Euler(DateTime.Now.Second * 360 / 60, 0, 0);
    }

}