using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Signs : MonoBehaviour
{
    public Text dialogText;
    public GameObject dialogImage;
    [TextArea]
    public string signDialog;
    bool Active;


    void Update()
    {
        if (Input.GetKeyDown("e") && Active)
        {
            if (dialogImage.activeInHierarchy)
            {
                dialogImage.SetActive(false);
            }
            else
            {
                dialogImage.SetActive(true);
                dialogText.text = signDialog;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            Active = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            Active = false;
            dialogImage.SetActive(false);
        }
    }
}
