using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Routes : MonoBehaviour
{
    public int RouteNo;
    public static int rn;

    public PokemonBase[] WB = new PokemonBase[20];
    public int[] WL = new int[20];

    public static PokemonBase[] WildEncounters = new PokemonBase[20];
    public static int[] WildLevels = new int[20];

    void Start()
    {
        rn = RouteNo;
        WildEncounters = WB;
        WildLevels = WL;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (BattleSystem.needReset == true || TallGrass.encounterRate == 0)
        {
            GetEncounterRate();
            BattleSystem.needReset = false;
        }
    }

    public void GetEncounterRate()
    {
        switch (RouteNo)
        {
            case 1:
                TallGrass.encounterRate = Random.Range(100, 200);
                break;
            case 2:
                TallGrass.encounterRate = Random.Range(200, 300);
                break;
            case 3:
                TallGrass.encounterRate = Random.Range(300, 400);
                break;
        }
    }

}

