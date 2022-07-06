using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class XandZero : MonoBehaviour
{
    public static int counter = 0;
    public static int vict = -1;
    public static int[,] verif = new int[3, 3];
    private static int mark = 0;
    public void Start()
    {
        for(int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                verif[i,j] = -1;
            }
        }
    }
    public int row, column;
    private void OnMouseDown()
    {
        if (vict == -1)
        {
            if (GetComponent<TMP_Text>().text == "X" || GetComponent<TMP_Text>().text == "O")
            {

            }
            else
            {
                GetComponent<TMP_Text>().text = counter % 2 == 0 ? "X" : "O";
                ++counter;
                verif[row, column] = counter % 2;
                Debug.Log(message: "Am apasat pe casusta " + row + " " + column + "Valoarea este " + verif[row, column]);
            }
        }
    }
    private void Update()
    {
        if (verif[0, 0] == verif[1, 1] && verif[2, 2] == verif[0, 0] && verif[0, 0] != -1)
        {
            vict = verif[0, 0];
        }
        if (verif[2, 0] == verif[1, 1] && verif[0, 2] == verif[2, 0] && verif[2, 0] != -1)
        {
            vict = verif[2, 0];
        }
        if (verif[0, 0] == verif[0, 1] && verif[0, 2] == verif[0, 1] && verif[0, 1] != -1)
        {
            vict = verif[0, 1];
        }
        if (verif[1, 0] == verif[1, 1] && verif[1, 2] == verif[1, 0] && verif[1, 0] != -1)
        {
            vict = verif[1, 0];
        }
        if (verif[2, 0] == verif[2, 1] && verif[2, 2] == verif[2, 0] && verif[2, 0] != -1)
        {
            vict = verif[2, 0];
        }
        if (verif[0, 0] == verif[1, 0] && verif[2, 0] == verif[1, 0] && verif[1, 0] != -1)
        {
            vict = verif[1, 0];
        }
        if (verif[0, 1] == verif[1, 1] && verif[2, 1] == verif[1, 1] && verif[1, 1] != -1)
        {
            vict = verif[1, 1];
        }
        if (verif[0, 2] == verif[1, 2] && verif[2, 2] == verif[1, 2] && verif[1, 2] != -1)
        {
            vict = verif[1, 2];
        }
        if (vict == 1)
        {
            GameObject.Find("Winscreen").GetComponent<TMP_Text>().text = "A castigat X";
        }
        if (vict == 0)
        {
            GameObject.Find("Winscreen").GetComponent<TMP_Text>().text = "A castigat O";
        }
        for(int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                if (verif[i, j] == -1)
                {
                    mark = 0;
                    break;
                }
                else
                {
                    mark = 1;
                }
            }
        }
        if (mark == 1 && (GameObject.Find("Winscreen").GetComponent<TMP_Text>().text == ""))
        {
            GameObject.Find("Winscreen").GetComponent<TMP_Text>().text = "Egalitate";
        }
    }
}
