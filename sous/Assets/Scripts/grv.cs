using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grv : MonoBehaviour
{
    public float forse1 = 0;
    public float forse2 = 0;
    public float forse3 = 0;
    public float forse4 = 0;
    public HashSet<Rigidbody> affectedBodies1 = new HashSet<Rigidbody>();
    public HashSet<Rigidbody> affectedBodies2 = new HashSet<Rigidbody>();
    public HashSet<Rigidbody> affectedBodies3 = new HashSet<Rigidbody>();
    public HashSet<Rigidbody> affectedBodies4 = new HashSet<Rigidbody>();
    private Rigidbody componentRB;
    private float G = 9.81F;

    public static int Frs = 0;
    public static int s = 0;
    // Start is called before the first frame update
    void Start()
    {
        componentRB = GetComponent<Rigidbody>();
        Application.targetFrameRate = 144;
    }

    private void OnTriggerEnter(Collider other) //добавление в массивы обьекта при вхождении в область действия
    {
        if (other.gameObject.tag == "prt1")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies1.Add(other.attachedRigidbody);
                //Frs++;
            }
        }
        if (other.gameObject.tag == "prt2")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies2.Add(other.attachedRigidbody);
                //Frs++;
            }
        }
        if (other.gameObject.tag == "prt3")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies3.Add(other.attachedRigidbody);
                //Frs++;
            }
        }
        if (other.gameObject.tag == "prt4")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies4.Add(other.attachedRigidbody);
                //Frs++;
            }
        }
        
    }
    private void OnTriggerExit(Collider other) //удаление из массивов обьекта при выхождении из облости действия
    {
        if (other.gameObject.tag == "prt1")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies1.Remove(other.attachedRigidbody);

            }
        }
        if (other.gameObject.tag == "prt2")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies2.Remove(other.attachedRigidbody);

            }
        }
        if (other.gameObject.tag == "prt3")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies3.Remove(other.attachedRigidbody);

            }
        }
        if (other.gameObject.tag == "prt4")
        {
            if (other.attachedRigidbody != null)
            {
                affectedBodies4.Remove(other.attachedRigidbody);

            }
        }
    }
    void Update()
    {
        if (componentRB.tag == "prt1")
        {
            forse1 = SendRule.R11;
            forse2 = SendRule.R12;
            forse3 = SendRule.R13;
            forse4 = SendRule.R14;
        }
        if (componentRB.tag == "prt2")
        {
            forse1 = SendRule.R21;
            forse2 = SendRule.R22;
            forse3 = SendRule.R23;
            forse4 = SendRule.R24;
        }
        if (componentRB.tag == "prt3")
        {
            forse1 = SendRule.R31;
            forse2 = SendRule.R32;
            forse3 = SendRule.R33;
            forse4 = SendRule.R34;
        }
        if (componentRB.tag == "prt4")
        {
            forse1 = SendRule.R41;
            forse2 = SendRule.R42;
            forse3 = SendRule.R43;
            forse4 = SendRule.R44;
        }


        s = 0;
        if (0.1f<=Mathf.Abs(forse1))                                                        //не считаем силу если множетель меньше 0.1 по модулю 
        {
            foreach (Rigidbody body in affectedBodies1)
            {
                Vector3 dirictionToParticle = (transform.position - body.position).normalized; //вектор по напралению к обьекту
                float dst = (transform.position - body.position).magnitude; //расчет расстояния до обьекта
                float frs1 = G * body.mass * componentRB.mass / (dst * dst+ 0.1f); //расчет силы по вектору
                body.AddForce(dirictionToParticle * (frs1 * forse1)); //применение силы
                
            }

        }

        if (0.1f <= Mathf.Abs(forse2))
        {
            foreach (Rigidbody body in affectedBodies2)
            {

                Vector3 dirictionToParticle = (transform.position - body.position).normalized; //вектор по напралению к обьекту
                float dst = (transform.position - body.position).magnitude; //расчет расстояния до обьекта
                float frs1 = G * body.mass * componentRB.mass / (dst * dst + 0.1f); //расчет силы по вектору
                                                                             
                body.AddForce(dirictionToParticle * (frs1 * forse2)); //применение силы
            }
        }

        if (0.1f <= Mathf.Abs(forse3))
        {
            foreach (Rigidbody body in affectedBodies3)
            {

                Vector3 dirictionToParticle = (transform.position - body.position).normalized; //вектор по напралению к обьекту
                float dst = (transform.position - body.position).magnitude; //расчет расстояния до обьекта
                float frs1 = G * body.mass * componentRB.mass / (dst * dst + 0.1f); //расчет силы по вектору
                                                                            
                body.AddForce(dirictionToParticle * (frs1 * forse3)); //применение силы
            }
        }
        if (0.1f <= Mathf.Abs(forse4))
        {
            foreach (Rigidbody body in affectedBodies4)
            {

                Vector3 dirictionToParticle = (transform.position - body.position).normalized; //вектор по напралению к обьекту
                float dst = (transform.position - body.position).magnitude; //расчет расстояния до обьекта
                float frs1 = G * body.mass * componentRB.mass / (dst * dst+0.1f); //расчет силы по вектору

                body.AddForce(dirictionToParticle * (frs1 * forse4)); //применение силы
            }
        }
        Frs = affectedBodies1.Count+affectedBodies2.Count+affectedBodies3.Count+affectedBodies4.Count+1;
        //componentRB.velocity = componentRB.velocity * 0.9995f; //постепенное замедление частиц для стабилизации симметричных систем
        
    }




    //public void DeleteAll1() { affectedBodies1.Clear(); }
    //public void DeleteAll2() { affectedBodies2.Clear(); }
    //public void DeleteAll3() { affectedBodies3.Clear(); }
    //public void DeleteAll4() { affectedBodies4.Clear(); }

}
