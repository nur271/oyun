using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class veriler2 : MonoBehaviour
{
    public static veriler2 instance;
    public Text scortext;
    int skorpuan;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void artir()
    {

        skorpuan += 1;
        scortext.text = skorpuan.ToString();
    }
}
