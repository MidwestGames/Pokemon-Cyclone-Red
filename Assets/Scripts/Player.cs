using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private static Rigidbody2D rb;
    private Animator anim;
    Vector3 change = new Vector3();
    public static bool inBattle;
    public static bool moveable;
    public static bool isMoving;
    public int step;

    public VectorValue startingPosition;

    public PokemonBase[] team = new PokemonBase[6];
    public int[] teamlevels = new int[6];

    public BattleUnit PlayerUnit;
    public BattleSystem system;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        inBattle = false;
        moveable = true;
        isMoving = true;

        transform.position = startingPosition.initialValue;
    }
   
    void PlayerMovement()
    {
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (change.x != 0 || change.y != 0)
        {
            MoveCharacter();
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
            anim.SetBool("isMoving", true);
            step++;
            isMoving = true;
        }
        else
        {
            anim.SetBool("isMoving", false);
            isMoving = false;
        }
    }
    void Update()
    {
        if (!inBattle)
        {
            PlayerMovement();
        }
    }
    void MoveCharacter()
    {
        rb.MovePosition(transform.position + change * speed);
    }
}