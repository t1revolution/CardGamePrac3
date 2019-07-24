using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragObj : MonoBehaviour
{ 
    public CARD.STEP step = CARD.STEP.NONE;
    public DICE.STEP dice_step = DICE.STEP.NONE;
    private DICE.EFFECT reference = DICE.EFFECT.NONE;
    //private CARD.EFFECT reference = CARD.EFFECT.NONE;
    private Vector3 dice_position;
    private bool activate = false;
    public Transform parentTransform;
    public int x;
    public int y;

    private Image image;
    private Sprite sprite;
    enum Type
    {
        ATTACK,
        SUPPORT,
        REFLECT,
    };

    public void OnUserAction()
    {
        this.transform.localScale = new Vector3(1.0f, 1.5f, 0.0f);
        this.step = CARD.STEP.TOUCHE;
    }
    /*
    public void DiceAction()
    {
        //this.transform.localScale = new Vector3(5.0f, 7.5f, 0.0f);
        //this.transform.position = new Rect(400, 350, 100, 90);
        this.transform.localScale = new Vector3(0.6f, 0.6f, 0.0f);
        this.dice_step = DICE.STEP.TOUCHE;
    }
    */

    // 攻撃対象選択時のみ接触判定で機能する関数+
    // この関数をお払い箱にする想定で、activate,selectを
    // Cardeffectのカード効果処理のところでいじるので注意
    public void DiceTarget()
    {
        Debug.Log("target:");

        //if (this.reference != CARD.EFFECT.CANCEL && cost > 0)
        if (this.reference != DICE.EFFECT.CANCEL)
        {
            //this.transform.localScale = new Vector3(0.6f, 0.6f, 0.0f);
            Dice dice = GetComponentInParent<Dice>();
            CardEffect cardeffect = GetComponentInParent<CardEffect>();
            bool self_activate = dice.activate;
            activate = cardeffect.DiceExistActivate();
            if (activate == true && self_activate == false)
            {
                this.dice_step = DICE.STEP.TARGET;
                dice_position = this.transform.position;
                Debug.Log("dice_position.x:" + dice_position.x);
                Debug.Log("dice_position.y:" + dice_position.y);
                dice.selected = true;
            }
        }
        this.reference = DICE.EFFECT.NONE;
    }

    // CardObjからcard名を受け取り発動タイプを切り分ける関数
    // ダイスの移動に関する関数
    public void dicetranslate1()
    {
        this.dice_step = DICE.STEP.TOUCHE1;
    }
    // ダイスの移動に関する関数** 2とはSupportカードで起きたバグのためselected
    // をここで変更するために処理を変えたため必要になった。
    public void dicetranslate2_1()
    {
        this.dice_step = DICE.STEP.TOUCHE2_1;
    }
    // ダイスの移動に関する関数
    public void dicetranslate2_2()
    {
        this.dice_step = DICE.STEP.TOUCHE2_2;
    }

    public void dicetranslate_S_1()
    {
        this.dice_step = DICE.STEP.TOUCHE_S_1;
    }

    // ダイスのダメージに関する関数
    public void dicestep_damage()
    {
        this.dice_step = DICE.STEP.DAMAGED;
    }

    private GameObject Get_owncard_Object()
    {
        Dice dice = GetComponentInParent<Dice>();
        var targets = GameObject.FindGameObjectsWithTag("CARD");
        GameObject owncard = targets[0];
        foreach (GameObject target in targets)
        {
            if (target.GetComponent<Card>().flag == dice.flag)
            {
                owncard = target;
                break;
            }
        }
        return owncard;
    }

    /*
    // 攻撃を行うダイスを選択する際のみ機能する関数
    public void AttackDice_select()
    {
        Debug.Log("cost1:");
        if (this.reference != CARD.EFFECT.CANCEL)
        {
            Card card = GetComponentInParent<Card>();
            CardEffect cardeffect = GetComponentInParent<CardEffect>();
            bool self_activate = card.activate;
            activate = cardeffect.ExistActivate();
            if (activate == true && self_activate == false)
            {
                this.step = CARD.STEP.COST;
                card_position = this.transform.position;
                Debug.Log("card_position.x:" + card_position.x);
                Debug.Log("card_position.y:" + card_position.y);
                card.selected = true;
            }
        }
        this.reference = CARD.EFFECT.NONE;
    }
    */

    void OnGUI()
    {
        float per1x = 65f;
        float per1y = 65f;
        float basex = 735f + per1x;
        float basey = 590f + per1y;

        if (dice_step == DICE.STEP.TOUCHE1)
        {
            Dice dice = GetComponentInParent<Dice>();
            Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();

            GameObject gameObj = Get_owncard_Object();
            Card card = gameObj.GetComponent<Card>();
            CardEffect cardeffect = gameObj.GetComponent<CardEffect>();

            //List<KomaMove> moves = new List<KomaMove>();
            int[,] moves = new int[4, 2];
            bool[] koma_able = new bool[4];
            float[,] koma_position = new float[4,2];

            moves = dice_move1.GetMoves();
            Vector3 tmp = this.transform.position;

            for(int i = 0; i < 4; i++)
            {
                if (dice.x + moves[i,0] > 5 || dice.x + moves[i, 0] < 1)
                {
                    koma_able[i] = false;　
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    continue;
                }
                if (dice.y + moves[i, 1] > 5 || dice.y + moves[i, 1] < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    continue;
                }
                if (dice.flag == true)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66),"");
                    koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                    koma_able[i] = activate_i;
                }
                else if (dice.flag == false)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66), "");
                    koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                    koma_able[i] = activate_i;
                }
            }

            if (koma_able[0] == true)
            {
                Debug.Log("0 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[0, 0], koma_position[0, 1], 0);

                dice.x = dice.x + moves[0, 0];
                dice.y = dice.y + moves[0, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[0, 0]:" + koma_position[0, 0] + "koma_position[0, 1]:" + koma_position[0, 1]);

                cardeffect.S_2selected_restore();

                /*
                GameObject gameObj = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameObj.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;

                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);

                //スプライトの差し替えはいらないが、移動先のマスにほかの駒が存在するなら大きさを小さくして同じマスに表示させる。
  　            if (card.type == (int)Type.REFLECT)
                {
                    sprite = Resources.Load<Sprite>("back_1");
                    image = this.GetComponent<Image>();
                    image.sprite = sprite;
                }
                */
            }
            if (koma_able[1] == true)
            {
                Debug.Log("1 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[1, 0], koma_position[1, 1], 0);

                dice.x = dice.x + moves[1, 0];
                dice.y = dice.y + moves[1, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[1, 0]:" + koma_position[1, 0] + "koma_position[1, 1]:" + koma_position[1, 1]);
                cardeffect.S_2selected_restore();
            }
            if (koma_able[2] == true)
            {
                Debug.Log("2 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[2, 0], koma_position[2, 1], 0);

                dice.x = dice.x + moves[2, 0];
                dice.y = dice.y + moves[2, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[2, 0]:" + koma_position[2, 0] + "koma_position[2, 1]:" + koma_position[2, 1]);
                cardeffect.S_2selected_restore();
            }
            if (koma_able[3] == true)
            {
                Debug.Log("3 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[3, 0], koma_position[3, 1], 0);

                dice.x = dice.x + moves[3, 0];
                dice.y = dice.y + moves[3, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[3, 0]:" + koma_position[3, 0] + "koma_position[3, 1]:" + koma_position[3, 1]);
                cardeffect.S_2selected_restore();
            }
        }

        if (dice_step == DICE.STEP.TOUCHE2_1)
        {
            Dice dice = GetComponentInParent<Dice>();
            Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();
            
            //List<KomaMove> moves = new List<KomaMove>();
            int[,] moves = new int[4, 2];
            bool[] koma_able = new bool[4];
            float[,] koma_position = new float[4,2];

            moves = dice_move1.GetMoves();
            Vector3 tmp = this.transform.position;

            for(int i = 0; i < 4; i++)
            {
                if (dice.x + moves[i,0] > 5 || dice.x + moves[i, 0] < 1)
                {
                    koma_able[i] = false;　
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    continue;
                }
                if (dice.y + moves[i, 1] > 5 || dice.y + moves[i, 1] < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    continue;
                }
                if (dice.flag == true)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66),"");
                    koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                    koma_able[i] = activate_i;
                }
                else if (dice.flag == false)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66), "");
                    koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                    koma_able[i] = activate_i;
                }
            }

            if (koma_able[0] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[0, 0], koma_position[0, 1], 0);
                dice.x = dice.x + moves[0, 0];
                dice.y = dice.y + moves[0, 1];
                dice.selected = true;
            }
            if (koma_able[1] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[1, 0], koma_position[1, 1], 0);
                dice.x = dice.x + moves[1, 0];
                dice.y = dice.y + moves[1, 1];
                dice.selected = true;
            }
            if (koma_able[2] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[2, 0], koma_position[2, 1], 0);
                dice.x = dice.x + moves[2, 0];
                dice.y = dice.y + moves[2, 1];
                dice.selected = true;
            }
            if (koma_able[3] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[3, 0], koma_position[3, 1], 0);
                dice.x = dice.x + moves[3, 0];
                dice.y = dice.y + moves[3, 1];
                dice.selected = true;
            }
        }

        if (dice_step == DICE.STEP.TOUCHE2_2)
        {
            Dice dice = GetComponentInParent<Dice>();
            Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();
            
            //List<KomaMove> moves = new List<KomaMove>();
            int[,] moves = new int[9, 2];
            bool[] koma_able = new bool[9];
            float[,] koma_position = new float[9,2];

            moves = dice_move1.GetMoves_2();
            Vector3 tmp = this.transform.position;

            for(int i = 0; i < 9; i++)
            {
                if (dice.x + moves[i,0] > 5 || dice.x + moves[i, 0] < 1)
                {
                    koma_able[i] = false;　
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    continue;
                }
                if (dice.y + moves[i, 1] > 5 || dice.y + moves[i, 1] < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    continue;
                }
                if (dice.flag == true)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66),"");
                    koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                    koma_able[i] = activate_i;
                }
                else if (dice.flag == false)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66), "");
                    koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                    koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);

                    koma_able[i] = activate_i;
                }
            }

            if (koma_able[0] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[0, 0], koma_position[0, 1], 0);
                dice.x = dice.x + moves[0, 0];
                dice.y = dice.y + moves[0, 1];
                dice.selected = true;
            }
            if (koma_able[1] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[1, 0], koma_position[1, 1], 0);
                dice.x = dice.x + moves[1, 0];
                dice.y = dice.y + moves[1, 1];

                // A_9 の攻撃後の移動ができてここでできない理由がわからないが、時間の都合上ここで整合性をとって
                // S1_S3_S4_S6_processing を機能させることを優先する。
                dice.selected = true;
            }
            if (koma_able[2] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[2, 0], koma_position[2, 1], 0);
                dice.x = dice.x + moves[2, 0];
                dice.y = dice.y + moves[2, 1];
                dice.selected = true;
            }
            if (koma_able[3] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[3, 0], koma_position[3, 1], 0);
                dice.x = dice.x + moves[3, 0];
                dice.y = dice.y + moves[3, 1];
                dice.selected = true;
            }
            if (koma_able[4] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[4, 0], koma_position[4, 1], 0);
                dice.x = dice.x + moves[4, 0];
                dice.y = dice.y + moves[4, 1];
                dice.selected = true;
            }
            if (koma_able[5] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[5, 0], koma_position[5, 1], 0);
                dice.x = dice.x + moves[5, 0];
                dice.y = dice.y + moves[5, 1];
                dice.selected = true;
            }
            if (koma_able[6] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[6, 0], koma_position[6, 1], 0);
                dice.x = dice.x + moves[6, 0];
                dice.y = dice.y + moves[6, 1];
                dice.selected = true;
            }
            if (koma_able[7] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[7, 0], koma_position[7, 1], 0);
                dice.x = dice.x + moves[7, 0];
                dice.y = dice.y + moves[7, 1];
                dice.selected = true;
            }
            if (koma_able[8] == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[8, 0], koma_position[8, 1], 0);
                dice.x = dice.x + moves[8, 0];
                dice.y = dice.y + moves[8, 1];
                dice.selected = true;
            }
        }

        if (dice_step == DICE.STEP.TOUCHE_S_1)
        {
            Dice dice = GetComponentInParent<Dice>();
            Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();

            int[,] moves = new int[1, 2];
            bool koma_able = false;
            float[,] koma_position = new float[4, 2];

            if (dice.flag == false)
            {
                moves[0, 0] = 0;
                moves[0, 1] = 1;
            }
            else if (dice.flag == true)
            {
                moves[0, 0] = 0;
                moves[0, 1] = -1;
            }

            if (dice.x + moves[0, 0] <= 5 && dice.x + moves[0, 0] >= 1)
            {
                if (dice.y + moves[0, 1] <= 5 && dice.y + moves[0, 1] >= 1)
                {
                    koma_able = true;
                }
            }
            
            koma_position[0, 0] = basex - per1x * (dice.x + moves[0, 0]);
            koma_position[0, 1] = basey - per1y * (dice.y + moves[0, 1]);
            if (koma_able == true)
            {
                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[0, 0], koma_position[0, 1], 0);
                dice.movecount += 1;

                dice.x = dice.x + moves[0, 0];
                dice.y = dice.y + moves[0, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[0, 0]:" + koma_position[0, 0] + "koma_position[0, 1]:" + koma_position[0, 1]);
            }
        }

        else if (dice_step == DICE.STEP.DAMAGED)
        {
            Debug.Log("SUCCEED!!!!");
            Dice dice = GetComponentInParent<Dice>();
            //dice.hp -= 1;
            this.dice_step = DICE.STEP.NONE;
        }

        else if (dice_step == DICE.STEP.TARGET)
        {
            CardEffect cardeffect = GetComponentInParent<CardEffect>();
            Dice dice = GetComponentInParent<Dice>();
            //int hand_num;
            //int cost;
            //cost = cardeffect.Getcost();
            //hand_num = cardeffect.GetHand();
            int selected_cost;
            selected_cost = cardeffect.DiceExistSelected();

            //bool ret = GUI.Button(new Rect(550, 350, 100, 90), "コストとして支払うカード");
            // タップされた手札にボタンを生成したい
            //bool ret = GUI.Button(new Rect(card_position.x + 500f, card_position.y - 500f, 200, 300), "コストとして選択されたカード");
            //bool ret = GUI.Button(new Rect(card_position.x + 620f, card_position.y + 640f, 80, 120), "select");
            //bool ret = GUI.Button(new Rect(dice_position.x - 40f, dice_position.y + 700f, 80, 120), "select");
            bool ret = GUI.Button(new Rect(basex - 33f - per1x * dice.x, basey - 432f + per1y * dice.y, 66, 66), "select");
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.dice_step = DICE.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
                this.reference = DICE.EFFECT.CANCEL;
                dice.selected = false;
            }
            if (selected_cost == 2)
            {
                //this.step = CARD.STEP.DISCAHRGE;
                bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "選択したダイスを攻撃します。よろしいですか?");
                int checkcost = cardeffect.Getcost();
                if (card_choose == true || checkcost == 0)
                {
                    var targets = GameObject.FindGameObjectsWithTag("DICE");
                    this.dice_step = DICE.STEP.IDLE;
                    foreach (GameObject target in targets)
                    {
                        if (target.GetComponent<Dice>().selected == true)
                        {
                            GameObject gameObj = GameObject.Find("GameMaster");
                            GameMaster gamemaster = gameObj.GetComponent<GameMaster>();
                            //player1 player = gamemaster.currentPlayer;
                            //player.ActivationCostFromHand(target.GetComponent<Card>());
                        }
                    }
                    cardeffect.DiceFlagrestore();
                }
            }
        }


        /*
        else if (dice_step == DICE.STEP.ATTACK)
        {
            CardEffect cardeffect = GetComponentInParent<CardEffect>();
            Card card = GetComponentInParent<Card>();
            int hand_num;
            int selected_cost;
            int cost;
            cost = cardeffect.Getcost();
            hand_num = cardeffect.GetHand();
            selected_cost = cardeffect.ExistSelected();

            bool ret = GUI.Button(new Rect(card_position.x - 40f, card_position.y + 700f, 80, 120), "select");
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
                this.reference = CARD.EFFECT.CANCEL;
                card.selected = false;

                //card.activate = true;
                //card_position = new Vector3();
            }
            if (selected_cost == cost)
            {
                //this.step = CARD.STEP.DISCAHRGE;
                bool card_choose = GUI.Button(new Rect(350, 220, 500, 450), "選択したカードを捨てます。よろしいですか?");
                int checkcost = cardeffect.Getcost();
                if (card_choose == true || checkcost == 0)
                {
                    var targets = GameObject.FindGameObjectsWithTag("CARD");
                    this.step = CARD.STEP.IDLE;
                    foreach (GameObject target in targets)
                    {
                        if (target.GetComponent<Card>().selected == true)
                        {
                            GameObject gameObj = GameObject.Find("GameMaster");
                            GameMaster gamemaster = gameObj.GetComponent<GameMaster>();
                            player1 player = gamemaster.currentPlayer;
                            player.ActivationCostFromHand(target.GetComponent<Card>());
                        }
                    }
                    cardeffect.Flagrestore();
                }
            }
        }
        */

    }
}
