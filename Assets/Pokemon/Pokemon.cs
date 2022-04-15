using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    public PokemonBase Base { get; set; }
    public int Level { get; set; }

    public int HP { get; set; }
    public int CurrentHP { get; set; }


    public List<Move> Moves { get; set; }

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;

        HP = MaxHealth;
        CurrentHP = MaxHealth;

        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
                Moves.Add(new Move(move.Base));
            if (Moves.Count >= 4)
                break;
        }
    }

    public int MaxHealth
    {
        get { return Mathf.FloorToInt((Base.BaseHealth * Level) / 100) + Level + 10; }
    }
    public int Attack
    {
        get { return Mathf.FloorToInt((Base.BaseAttack * Level) / 100) + 5; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((Base.BaseDefense + Level) / 100) + 5; }
    }
    public int SpecialAttack
    {
        get { return Mathf.FloorToInt((Base.BaseSpAttack * Level) / 100) + 5; }
    }
    public int SpecialDefense
    {
        get { return Mathf.FloorToInt((Base.BaseSpDefense * Level) / 100) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((Base.BaseSpeed * Level) / 100) + 5; }
    }
}
