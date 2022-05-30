using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterObjs : MonoBehaviour
{

    public Text CountObjs;

    // Start is called before the first frame update
    void Start()
    {
        CountObjs = this.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        CountObjs.text = spawn.count.ToString();

    }
}