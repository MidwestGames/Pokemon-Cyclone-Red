using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] Text pokemonNameText;
    [SerializeField] Text levelText;
    [SerializeField] Text MaxHPText;
    [SerializeField] public Text CurrentHPText;

    public void SetData(Pokemon pokemon)
    {
        pokemonNameText.text = pokemon.Base.PokemonName;
        levelText.text = "" + pokemon.Level;
        MaxHPText.text = "" + pokemon.MaxHealth;
        CurrentHPText.text = "" + pokemon.CurrentHP;
    }
    public void ClearData(Pokemon pokemon)
    {
        pokemonNameText.text = "";
        levelText.text = "";
        MaxHPText.text = "";
        CurrentHPText.text = "";
    }
}
