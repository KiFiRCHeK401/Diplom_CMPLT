using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountForses : MonoBehaviour
{

    public Text Count;

    // Start is called before the first frame update
    void Start()
    {
        Count = this.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Count.text = grv.Frs.ToString();

    }
}