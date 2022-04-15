using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleSystem : MonoBehaviour
{
    public enum BattleState {Off,Start,PlayerTurn,EnemyTurn,Attack,Win,Loss};
    public GameObject Background;
    public static bool needReset;

    [SerializeField] BattleUnit PlayerUnit;
    [SerializeField] BattleHUD PlayerHUD;

    [SerializeField] BattleUnit EnemyUnit;
    [SerializeField] BattleHUD EnemyHUD;

    [SerializeField] Text Dialog;
    public GameObject movelist;
    public string encounterMessage;
    public string readyMessage;

    public Button moveTab;


    [SerializeField] public BattleState state;

    bool playerAttacked;


    public Button.ButtonClickedEvent openMoveTab;


    void Start()
    {
        state = BattleState.Off;
        openMoveTab = moveTab.onClick;
        openMoveTab = null;
    }
    void Update()
    {
        if (Player.inBattle)
        {
            if (state == BattleState.Off)
                state = BattleState.Start;

            else if (state == BattleState.PlayerTurn || state == BattleState.EnemyTurn)
            {
                if (EnemyUnit.Pokemon.CurrentHP <= 0)
                    state = BattleState.Win;
            }
        }
        if (state == BattleState.Start)
        {
            StartCoroutine(SetupBattle());
        }
        if (state == BattleState.PlayerTurn)
        {
            StartCoroutine(PlayerAttack());
            if (playerAttacked == true)
                state = BattleState.EnemyTurn;
        }
        if (state == BattleState.Win)
        {
            StartCoroutine(BattleWon());
        }
        //Debug.Log(Dialog.text);
        Debug.Log(state);
        Debug.Log(openMoveTab);
    }

    public IEnumerator SetupBattle()
    {

        Background.SetActive(true);
        yield return new WaitForSeconds(2);
        EnemyUnit.Setup();
        EnemyHUD.SetData(EnemyUnit.Pokemon);
        yield return new WaitForSeconds(2);
        PlayerUnit.Setup();
        PlayerHUD.SetData(PlayerUnit.Pokemon);
        yield return new WaitForSeconds(2);
        StartCoroutine(ChangeStatetoPlayerTurn());
        yield break;
    }
    public IEnumerator ChangeStatetoPlayerTurn()
    {
        state = BattleState.PlayerTurn;
        yield break;
    }

    public IEnumerator BattleWon()
    {
        yield return new WaitForSeconds(2f);
        EnemyHUD.ClearData(EnemyUnit.Pokemon);
        EnemyUnit.Clear();
        //Earn XP, etc.
        yield return new WaitForSeconds(2f);
        PlayerHUD.ClearData(PlayerUnit.Pokemon);
        PlayerUnit.Clear();
        yield return new WaitForSeconds(2f);
        Player.inBattle = false;
        Background.SetActive(false);
        //Dialog.text = "";
        state = BattleState.Off;
        yield break;
    }    
    public IEnumerator PlayerAttack()
    {
        // if (Input.GetKeyDown("x"))
        // {
        //     EnemyUnit.Pokemon.CurrentHP -= 5;
        //     EnemyHUD.CurrentHPText.text = "" + EnemyUnit.Pokemon.CurrentHP;
        //     playerAttacked = true;
        //     yield break;
        // }
        
        if(Input.GetMouseButton(0) && openMoveTab != null)
        {
            movelist.SetActive(true);
            yield break;
        }
    }
}
