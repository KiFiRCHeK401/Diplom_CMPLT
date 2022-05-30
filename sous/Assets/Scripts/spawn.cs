using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obj;
    public List<GameObject> objs;
    public int n = 0;
    public int velocity = 0;
    public int scale = 0;
    public int type = 0;

    public static int count = 0;

    public System.Random rnd = new System.Random();
    static string componentTag1 = "prt1";
    static string componentTag2 = "prt2";
    static string componentTag3 = "prt3";
    static string componentTag4 = "prt4";



    void Start()
    {
        int i = 0;
        GameObject a;
        if (type == 1)
        {
            obj.tag = componentTag1;
        }
        if (type == 2)
        {
            obj.tag = componentTag2;
        }
        if (type == 3)
        {
            obj.tag = componentTag3;
        }
        if (type == 4)
        {
            obj.tag = componentTag4;
        }

        for (i=0;i<n;i++)
        {
            a = Instantiate(obj);
            
            a.transform.position = new Vector3(rnd.Next(-scale, scale), rnd.Next(-scale, scale), rnd.Next(-scale, scale));
            a.GetComponent<Rigidbody>().AddForce(new Vector3(rnd.Next(-velocity, velocity), rnd.Next(-velocity, velocity), rnd.Next(-velocity, velocity)));
            objs.Add(a);
            count = count + 1;
        }

    }

    void Update()
    {

    }


    




    int NPRT;



    public void AddPrt1()
    {
        int i = 0;
        NPRT = PRTsend1.AmountPRT1;
        GameObject a;
        obj.tag = componentTag1;
        for (i = 0; i < NPRT; i++)
        {
            a = GameObject.Instantiate(obj);
            a.transform.position = new Vector3(rnd.Next(-25, 25), rnd.Next(-25, 25), rnd.Next(-25, 25));
            objs.Add(a);
            spawn.count = spawn.count + 1;
        }
    }
    public void AddPrt2()
    {
        int i = 0;
        NPRT = PRTsend1.AmountPRT2; //сюда передавать значение с поля ввода слева от кнопки
        GameObject a;
        obj.tag = componentTag2;
        for (i = 0; i < NPRT; i++)
        {
            a = GameObject.Instantiate(obj);
            a.transform.position = new Vector3(rnd.Next(-25, 25), rnd.Next(-25, 25), rnd.Next(-25, 25));
            objs.Add(a);
            spawn.count = spawn.count + 1;
        }
    }
    public void AddPrt3()
    {
        int i = 0;
        NPRT = PRTsend1.AmountPRT3; //сюда передавать значение с поля ввода слева от кнопки
        GameObject a;
        obj.tag = componentTag3;
        for (i = 0; i < NPRT; i++)
        {
            a = GameObject.Instantiate(obj);
            a.transform.position = new Vector3(rnd.Next(-25, 25), rnd.Next(-25, 25), rnd.Next(-25, 25));
            objs.Add(a);
            spawn.count = spawn.count + 1;
        }
    }
    public void AddPrt4()
    {
        int i = 0;
        NPRT = PRTsend1.AmountPRT4; //сюда передавать значение с поля ввода слева от кнопки
        GameObject a;
        obj.tag = componentTag4;
        for (i = 0; i < NPRT; i++)
        {
            a = GameObject.Instantiate(obj);
            a.transform.position = new Vector3(rnd.Next(-25, 25), rnd.Next(-25, 25), rnd.Next(-25, 25));
            objs.Add(a);
            spawn.count = spawn.count + 1;
        }
    }
    public void DeleteAll()
    {
        foreach (GameObject body in objs)
        {
            Destroy(body);
        }
        grv.Frs = 0;
        count = 0;
        objs.Clear();
    }
}
