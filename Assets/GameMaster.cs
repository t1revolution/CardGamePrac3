using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public player1[] playerList;
    public DeckGenerater deckGenerater;
    public ManaGenerater manaGenerater;
    public DiceGenerater diceGenerater;
    public IEnumerator coroutine;
    public string current_phase;
    public string current_player;
    public int turn = 0;
    public float step_timer = 0.0f; //経過時間
    public GUIStyle guistyle; //フォントスタイル

    enum Phase
    {
        NONE = -1,
        INIT,
        DRAW,
        STANDBY,
        BATTLE,
        END,
    };
    enum Type
    {
        ATTACK,
        SUPPORT,
        REFLECT,
        MANA,
    };

    Phase phase;
    void Start()
    {
        deckGenerater = GetComponent<DeckGenerater>();
        manaGenerater = GetComponent<ManaGenerater>();
        diceGenerater = GetComponent<DiceGenerater>();
        phase = Phase.INIT;
        InitPhase();
    }

    void Update()
    {
        this.step_timer += Time.deltaTime;
    }

    List<DiceData> DiceDataList = new List<DiceData>()
    {
        new DiceData(1, "dice1", 6, 1, 5, true),
        new DiceData(2, "dice2", 6, 3, 5, true),
        new DiceData(3, "dice3", 6, 5, 5, true),
        new DiceData(4, "dice4", 6, 1, 1, false),
        new DiceData(5, "dice5", 6, 3, 1, false),
        new DiceData(6, "dice6", 6, 5, 1, false),
    };
    List<CardData> ManacardDataList1 = new List<CardData>()
    {
        new CardData(0, "M_1", (int)Type.MANA, 0, true, false, false),
        new CardData(1, "M_1", (int)Type.MANA, 0, true, false, false),
    };
    List<CardData> ManacardDataList2 = new List<CardData>()
    {
        new CardData(0, "M_1", (int)Type.MANA, 0, false, false, false),
        new CardData(1, "M_1", (int)Type.MANA, 0, false, false, false),
    };
    List<CardData> player1CardDataList = new List<CardData>()
    {
        new CardData(0, "A_1", (int)Type.ATTACK, 2, true, false, false),
        new CardData(1, "A_2", (int)Type.ATTACK, 1, true, false, false),
        new CardData(2, "A_3", (int)Type.ATTACK, 0, true, false, false),
        new CardData(3, "A_4", (int)Type.ATTACK, 0, true, false, false),
        new CardData(4, "A_5", (int)Type.ATTACK, 0, true, false, false),
        new CardData(5, "A_6", (int)Type.ATTACK, 2, true, false, false),
        new CardData(6, "A_7", (int)Type.ATTACK, 0, true, false, false),
        new CardData(7, "A_8", (int)Type.ATTACK, 0, true, false, false),
        new CardData(8, "A_9", (int)Type.ATTACK, 0, true, false, false),
        new CardData(9, "A_10", (int)Type.ATTACK, 1, true, false, false),
    };
    List<CardData> player2CardDataList = new List<CardData>()
    {
        new CardData(0, "A_11", (int)Type.ATTACK, 1, false, false, false),
        new CardData(1, "R_1", (int)Type.REFLECT, 1, false, false, false),
        new CardData(2, "R_2", (int)Type.REFLECT, 1, false, false, false),
        new CardData(3, "R_3", (int)Type.REFLECT, 1, false, false, false),
        new CardData(4, "R_4", (int)Type.REFLECT, 1, false, false, false),
        new CardData(5, "S_1", (int)Type.SUPPORT, 1, false, false, false),
        new CardData(6, "S_2", (int)Type.SUPPORT, 1, false, false, false),
        new CardData(7, "S_3", (int)Type.SUPPORT, 1, false, false, false),
        new CardData(8, "S_4", (int)Type.SUPPORT, 1, false, false, false),
        new CardData(9, "S_5", (int)Type.SUPPORT, 1, false, false, false),
    };

    public player1 currentPlayer;
    public player1 waitPlayer;
    void InitPhase()
    {
        Debug.Log("InitPhase");
        // デッキの生成
        Debug.Log("player1CardDataList" + player1CardDataList[1]);
        Debug.Log("player2CardDataList" + player2CardDataList[1]);
        Debug.Log("playerList[0].deck:" + currentPlayer.x);
        Debug.Log("playerList[0].deck" + waitPlayer.y);
        
        /*
        deckGenerater.Generate(player1CardDataList, playerList[0].deck);
        deckGenerater.Generate(player2CardDataList, playerList[1].deck);
        */
        deckGenerater.Generate(player1CardDataList, currentPlayer.deck);
        deckGenerater.Generate(player2CardDataList, waitPlayer.deck);
        manaGenerater.Generate(ManacardDataList1, currentPlayer.mana);
        manaGenerater.Generate(ManacardDataList2, waitPlayer.mana);
        diceGenerater.Generate(DiceDataList);
        //diceGenerater.Generate(DiceDataList, waitPlayer.mana);
        
        // 現在のプレイヤー
        currentPlayer = playerList[0];
        waitPlayer = playerList[1];

        coroutine = PhaseChange(false);
        Coroutine retA = StartCoroutine(coroutine);

        phase = Phase.DRAW;
        current_phase = "InitPhase";
        current_player = "自分";
        // ゲーム開始時に手札をセット
        for (int i = 0; i < 5; i++)
        {
            currentPlayer.Draw();
            waitPlayer.Draw();
        }
    }
    void DrawPhase()
    {
        Debug.Log("DrawPhase");
        // カードのドロー
        currentPlayer.Draw();
        phase = Phase.STANDBY;
        current_phase = "DrawPhase";
        if(currentPlayer != playerList[1])
        {
            current_player = "自分";
        }else{
            current_player = "相手";
        }
        turn += 1;
    }

    void StandbyPhase()
    {
        Debug.Log("StandbyPhase");
        // 手札のカードを場に出す
        //currentPlayer.StandbyPhaseAction();
        phase = Phase.BATTLE;
        current_phase = "StandbyPhase";
    }
    void BattlePhase()
    {
        Debug.Log("BattlePhase");
        //currentPlayer.BattlePhaseAction(waitPlayer);

        //currentPlayer.PushSettingCardOnFieldFromHand();

        phase = Phase.END;
        current_phase = "BattlePhase";
    }
    /*
    void CheckFieldCardHP()
    {
        for(int i = 0; i < playerList.Length; i++)
        {
            playerList[i].CheckFieldCardHP();
        }
    }
    */
    void EndPhase()
    {
        Debug.Log("EndPhase");
        currentPlayer.SetGraveyard();
        currentPlayer.SetManazone();
        player1 tmpPlayer = waitPlayer;
        waitPlayer = currentPlayer;
        currentPlayer = tmpPlayer;
        phase = Phase.DRAW;
        current_phase = "EndPhase";
    }

    public void PhaseControol()
    {
        //StopCoroutine("PhaseChange");
        coroutine = PhaseChange(true);
        StartCoroutine(coroutine);
        //StartCoroutine("PhaseChange");
    }

    IEnumerator PhaseChange(bool flag = false)
    {
        while (!Input.GetMouseButtonDown(0) && !Input.GetButtonDown("Jump") && !flag)
        {
            switch (phase)
            {
                case Phase.INIT:
                    Debug.Log("INIT_Phase");
                    break;
                case Phase.DRAW:
                    Debug.Log("DRAW_Phase");
                    break;
                case Phase.STANDBY:
                    Debug.Log("STANDBY_Phase");
                    break;
                case Phase.BATTLE:
                    Debug.Log("BATTLE_Phase");
                    break;
                case Phase.END:
                    Debug.Log("END_Phase");
                    break;
            }
            yield return null;
        }
        switch (phase)
        {
            case Phase.INIT:
                InitPhase();
                break;
            case Phase.DRAW:
                DrawPhase();
                break;
            case Phase.STANDBY:
                StandbyPhase();
                break;
            case Phase.BATTLE:
                BattlePhase();
                break;
            case Phase.END:
                EndPhase();
                break;
        }
        Debug.Log("test_end");
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        // 経過時間を表示
        GUI.Label(new Rect(40.0f, 10.0f, 200.0f, 20.0f),
            "時間" + Mathf.CeilToInt(this.step_timer).ToString() + "秒", guistyle);
        GUI.Label(new Rect(40.0f, 40.0f, 200.0f, 20.0f),
            "ターンプレイヤー:"  + current_player, guistyle);
        GUI.Label(new Rect(40.0f, 70.0f, 200.0f, 20.0f),
            "フェーズ:" + current_phase, guistyle);
        GUI.Label(new Rect(40.0f, 100.0f, 200.0f, 20.0f),
            "ターン数:" + turn, guistyle);
        GUI.color = Color.white;
    }
}
