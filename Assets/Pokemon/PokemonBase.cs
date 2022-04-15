using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string pokemonname;
    [SerializeField] int dexnumber;

    [TextArea]
    [SerializeField] string pokemondescription;

    [SerializeField] Sprite frontsprite;
    [SerializeField] Sprite backsprite;

    [SerializeField] Type type1;
    [SerializeField] Type type2;

    [SerializeField] int basehealth;
    [SerializeField] int baseattack;
    [SerializeField] int basedefense;
    [SerializeField] int basespecialattack;
    [SerializeField] int basespecialdefense;
    [SerializeField] int basespeed;

    [SerializeField] List<LearnableMove> learnablemoves;
    public string PokemonName
    {
        get { return pokemonname; }
    }
    public string PokemonDescription
    {
        get { return pokemondescription; }
    }
    public int DexNumber
    {
        get { return dexnumber; }
    }

    public int BaseHealth
    {
        get { return basehealth; }
    }
    public int BaseAttack
    {
        get { return baseattack; }
    }
    public int BaseDefense
    {
        get { return basedefense; }
    }
    public int BaseSpeed
    {
        get { return basespeed; }
    }
    public int BaseSpAttack
    {
        get { return basespecialattack; }
    }
    public int BaseSpDefense
    {
        get { return basespecialdefense; }
    }

    public Type Type1
    {
        get { return type1; }
    }
    public Type Type2
    {
        get { return type2; }
    }

    public Sprite FrontSprite
    {
        get { return frontsprite; }
    }
    public Sprite BackSprite
    {
        get { return backsprite; }
    }
    public List<LearnableMove> LearnableMoves
    {
        get { return learnablemoves; }
    }
}
[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public int Level
    {
        get { return level; }
    }
    public MoveBase Base
    {
        get { return moveBase; }
    }
}

public enum Type
{
    None,
    Grass,
    Fire,
    Water,
    Ground,
    Rock,
    Steel,
    Psychic,
    Poison,
    Dark,
    Normal,
    Fairy,
    Dragon,
    Fighting,
    Ghost, 
    Ice,
    Electric,
    Flying,
    Bug
}

public enum Nature
{
    Adamant,
    Bashful,
    Bold,
    Brave,
    Calm,
    Careful,
    Docile,
    Gentle,
    Hardy,
    Hasty,
    Impish,
    Jolly,
    Lax,
    Lonely,
    Mild,
    Modest,
    Naive,
    Naughty,
    Quiet,
    Quirky,
    Rash,
    Relaxed,
    Sassy,
    Serious,
    Timid
}

