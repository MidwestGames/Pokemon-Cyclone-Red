using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Regions : MonoBehaviour
{
    public GameObject regionBox;
    public Text regionName;
    public string townName;
    public string routeName;
    public static bool route;
    public static bool town;

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.name == "Player")
        {
            if (other.name == "Player" && route == false)
            {
                StartCoroutine(regionEnter());
                route = true;
                town = false;
            }
            else if (other.name == "Player" && route == true)
            {
                StartCoroutine(regionExit());
                route = false;
                town = true;
            }
        }
    }
    private IEnumerator regionEnter()
    {
        regionBox.SetActive(true);
        regionName.text = routeName;
        yield return new WaitForSeconds(5f);
        regionBox.SetActive(false);
    }
    private IEnumerator regionExit()
    {
        regionBox.SetActive(true);
        regionName.text = townName;
        yield return new WaitForSeconds(5f);
        regionBox.SetActive(false);
    }
}
