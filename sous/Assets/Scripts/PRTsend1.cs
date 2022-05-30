using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PRTsend1 : MonoBehaviour
{
    public static int AmountPRT1;
    public static int AmountPRT2;
    public static int AmountPRT3;
    public static int AmountPRT4;
    private InputField TextOnField;
    // Start is called before the first frame update
    void Start()
    {
        TextOnField = GetComponent<InputField>();
        TextOnField.text = "1";
    }



    public void Send1()
    {

        AmountPRT1 = int.Parse(TextOnField.text.ToString());
    }
    public void Send2()
    {

        AmountPRT2 = int.Parse(TextOnField.text.ToString());
    }
    public void Send3()
    {

        AmountPRT3 = int.Parse(TextOnField.text.ToString());
    }
    public void Send4()
    {

        AmountPRT4 = int.Parse(TextOnField.text.ToString());
    }


}
