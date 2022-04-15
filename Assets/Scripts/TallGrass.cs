using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallGrass : MonoBehaviour
{
    public static float encounterRate;
    public static float counter;
    int encounterNumber;

    public BattleUnit WildPokemon;

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.name == "Player" && Player.inBattle == false)
        {
            counter += 1f;
            if (counter >= encounterRate + 10)
            {
                encounterNumber = Random.Range(0, 2);
                counter = 0;
                Player.inBattle = true;
                Player.moveable = false;
                Player.isMoving = false;

                if (encounterNumber <= Routes.WildEncounters.Length)
                {
                    WildPokemon._Base = Routes.WildEncounters[encounterNumber];
                    WildPokemon.pokelevel = Routes.WildLevels[encounterNumber];
                }
                else
                {
                    WildPokemon._Base = Routes.WildEncounters[0];
                    WildPokemon.pokelevel = Routes.WildLevels[0];
                }
            }
        }
    }
}
