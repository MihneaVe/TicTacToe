using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("Text (TMP)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (1)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (2)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (3)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (4)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (5)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (6)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (7)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Text (TMP) (8)").GetComponent<TMP_Text>().text = "";
        GameObject.Find("Winscreen").GetComponent<TMP_Text>().text = "";
        GameObject.Find("X_NR").GetComponent<Counter>().Numaratoare();
        GameObject.Find("O_NR").GetComponent<Counter>().Numaratoare();
        XandZero.vict = -1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                XandZero.verif[i, j] = -1;
            }
        }
    }
}

