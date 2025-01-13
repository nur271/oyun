using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RockScript : MonoBehaviour
{
    public GameObject rock;
    public void OnTriggerEnter2D(Collider2D other)
    {
        rock.GetComponent<Rigidbody2D>().simulated = true;

    }


}