using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinscript : MonoBehaviour
{
    public Text puan;
    //public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy (gameObject);
        //coin.SetActive(false);
        puanartir();
    }
    public void puanartir()
        {


            veriler2.instance.artir();
        }
}
