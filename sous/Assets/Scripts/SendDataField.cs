using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Globalization;


public class SendDataField : MonoBehaviour
{
    public static Text AmountPRT1;
    public static Text AmountPRT2;
    public static Text AmountPRT3;
    public static Text AmountPRT4;

    public static float sPRT1;
    public static float sPRT2;
    public static float sPRT3;
    public static float sPRT4;

    private void Start()
    {
        AmountPRT1 = this.GetComponent<Text>();
        AmountPRT2 = this.GetComponent<Text>();
        AmountPRT3 = this.GetComponent<Text>();
        AmountPRT4 = this.GetComponent<Text>();
    }
    public void SendAmountPRT1()
    {
        sPRT1 = float.Parse(AmountPRT1.text, CultureInfo.InvariantCulture.NumberFormat);
    }
    public void SendAmountPRT2()
    {
        sPRT2 = float.Parse(AmountPRT2.text, CultureInfo.InvariantCulture.NumberFormat);
    }
    public void SendAmountPRT3()
    {
        sPRT3 = float.Parse(AmountPRT3.text, CultureInfo.InvariantCulture.NumberFormat);
    }
    public void SendAmountPRT4()
    {
        sPRT4 = float.Parse(AmountPRT4.text, CultureInfo.InvariantCulture.NumberFormat);
    }
}
