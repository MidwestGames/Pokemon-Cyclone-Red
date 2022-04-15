using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] public PokemonBase _Base;
    [SerializeField] public int pokelevel;

    [SerializeField] bool isPlayer;

    [SerializeField] public bool attacked;

    public Pokemon Pokemon { get; set; }

    Image i; 

    private void Start()
    {
        i = GetComponent<Image>();
    }
    public void Setup()
    {
        Pokemon = new Pokemon(_Base, pokelevel);

        if (isPlayer)
        {
            i.sprite = Pokemon.Base.BackSprite;
        }
        else
        {
            i.sprite = Pokemon.Base.FrontSprite;
        }

        attacked = false;
    }

    public void Clear()
    { 
        Pokemon = null;


        if (isPlayer)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1f);
        }
        else
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1f);
        }
    }
}