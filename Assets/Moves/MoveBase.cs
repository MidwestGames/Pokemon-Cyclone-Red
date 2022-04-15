using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveBase : ScriptableObject
{
    [SerializeField] string movename;

    [TextArea]
    [SerializeField] string movedescription;

    [SerializeField] MoveType mtype;

    [SerializeField] int basepower;
    [SerializeField] int accuracy;
    [SerializeField] Type type;
    [SerializeField] int powerpoints;

    public string MoveName
    {
        get { return movename; }
    }
    public string MoveDescription
    {
        get { return movedescription; }
    }
    public MoveType MType
    {
        get { return mtype; }
    }
    public int BasePower
    {
        get { return basepower; }
    }
    public int Accuracy
    {
        get { return accuracy; }
    }
    public int PowerPoints
    {
        get { return powerpoints; }
    }
    public Type Type
    {
        get { return type; }
    }
}

public enum MoveType
{
    Physical,
    Special,
    Status,
    Null
}
