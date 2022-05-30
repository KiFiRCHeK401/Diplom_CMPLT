using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendRule : MonoBehaviour
{
    private InputField TextOnField;

    public static float R11;
    public static float R12;
    public static float R13;
    public static float R14;
    public static float R21;
    public static float R22;
    public static float R23;
    public static float R24;
    public static float R31;
    public static float R32;   
    public static float R33;
    public static float R34;    
    public static float R41;
    public static float R42;
    public static float R43;
    public static float R44;

    void Start()
    {
        setDef();
    }




    public void setDef()
    {
        TextOnField = GetComponent<InputField>();
        if (TextOnField.name == "Prt1ToPrt1") { TextOnField.text = "1"; }
        if (TextOnField.name == "Prt2ToPrt1") { TextOnField.text = "-1"; }
        if (TextOnField.name == "Prt3ToPrt1") { TextOnField.text = "0"; }
        if (TextOnField.name == "Prt4ToPrt1") { TextOnField.text = "0"; }

        if (TextOnField.name == "Prt1ToPrt2") { TextOnField.text = "-1"; }
        if (TextOnField.name == "Prt2ToPrt2") { TextOnField.text = "1"; }
        if (TextOnField.name == "Prt3ToPrt2") { TextOnField.text = "0"; }
        if (TextOnField.name == "Prt4ToPrt2") { TextOnField.text = "0"; }

        if (TextOnField.name == "Prt1ToPrt3") { TextOnField.text = "1"; }
        if (TextOnField.name == "Prt2ToPrt3") { TextOnField.text = "1"; }
        if (TextOnField.name == "Prt3ToPrt3") { TextOnField.text = "2"; }
        if (TextOnField.name == "Prt4ToPrt3") { TextOnField.text = "1"; }

        if (TextOnField.name == "Prt1ToPrt4") { TextOnField.text = "-1"; }
        if (TextOnField.name == "Prt2ToPrt4") { TextOnField.text = "-1"; }
        if (TextOnField.name == "Prt3ToPrt4") { TextOnField.text = "1"; }
        if (TextOnField.name == "Prt4ToPrt4") { TextOnField.text = "10"; }
    }


    public void SR11() { R11 = float.Parse(TextOnField.text.ToString()); }
    public void SR12() { R12 = float.Parse(TextOnField.text.ToString()); }
    public void SR13() { R13 = float.Parse(TextOnField.text.ToString()); }
    public void SR14() { R14 = float.Parse(TextOnField.text.ToString()); }
    public void SR21() { R21 = float.Parse(TextOnField.text.ToString()); }
    public void SR22() { R22 = float.Parse(TextOnField.text.ToString()); }
    public void SR23() { R23 = float.Parse(TextOnField.text.ToString()); }
    public void SR24() { R24 = float.Parse(TextOnField.text.ToString()); }
    public void SR31() { R31 = float.Parse(TextOnField.text.ToString()); }
    public void SR32() { R32 = float.Parse(TextOnField.text.ToString()); }
    public void SR33() { R33 = float.Parse(TextOnField.text.ToString()); }
    public void SR34() { R34 = float.Parse(TextOnField.text.ToString()); }
    public void SR41() { R41 = float.Parse(TextOnField.text.ToString()); }
    public void SR42() { R42 = float.Parse(TextOnField.text.ToString()); }
    public void SR43() { R43 = float.Parse(TextOnField.text.ToString()); }
    public void SR44() { R44 = float.Parse(TextOnField.text.ToString()); }
}
