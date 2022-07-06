using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public int Xsc = 0;
    public int Osc = 0;
    public void Numaratoare()
    {
        if(GameObject.Find("Winscreen").GetComponent<TMP_Text>().text == "A castigat X" )
        {
            Xsc++;
            XandZero.counter = 0;
        }
        else if(GameObject.Find("Winscreen").GetComponent<TMP_Text>().text == "A castigat O" )
        {
            Osc++;
            XandZero.counter = 0;
        }
        GameObject.Find("X_NR").GetComponent<TMP_Text>().text = Xsc.ToString();
        GameObject.Find("O_NR").GetComponent<TMP_Text>().text = Osc.ToString();
    }
}
