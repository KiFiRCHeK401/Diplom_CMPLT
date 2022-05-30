using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFPS : MonoBehaviour
{
    public static float fps;
    public Text FPSCounter;
    private void Start()
    {
        FPSCounter = this.GetComponent<Text>();
    }
    private void Update()
    {
        fps = 1.0f / Time.deltaTime;
        fps = (int)fps;
        if (fps < 30)
        {
            if (fps < 20) {FPSCounter.color = Color.red;}
            else {FPSCounter.color = Color.yellow;}
        }
        else { FPSCounter.color = Color.green; }

        FPSCounter.text = fps.ToString();
    }
}
