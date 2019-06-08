using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CARD
{
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        TOUCHE,
        ACTIVATE,
    };
}

public class DICE
{
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        TOUCHE,
        DAMAGED,
    };
}

public class CardObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //public Dice dice;
    public CARD.STEP step = CARD.STEP.NONE;
    public DICE.STEP dice_step = DICE.STEP.NONE;
    public Transform parentTransform;
    public int x;
    public int y;

    //public Graveyard graveyard;


    private Image image;
    private Sprite sprite;
    enum Type
    {
        ATTACK,
        SUPPORT,
        REFLECT,
    };

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("OnBeginDrag");
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        parentTransform = transform.parent;
        transform.SetParent(transform.parent.parent);
    }
    public void OnDrag(PointerEventData data)
    {
        transform.position = data.position;
    }
    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("OneEndDrag");
        transform.SetParent(parentTransform);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    public void OnUserAction()
    {
        //this.transform.localScale = new Vector3(5.0f, 7.5f, 0.0f);
        //this.transform.position = new Rect(400, 350, 100, 90);
        this.transform.localScale = new Vector3(1.0f, 1.5f, 0.0f);
        this.step = CARD.STEP.TOUCHE;
    }
    public void DiceAction()
    {
        //this.transform.localScale = new Vector3(5.0f, 7.5f, 0.0f);
        //this.transform.position = new Rect(400, 350, 100, 90);
        this.transform.localScale = new Vector3(0.6f, 0.6f, 0.0f);
        this.dice_step = DICE.STEP.TOUCHE;
    }

    public void ccc()
    {
        this.step = CARD.STEP.IDLE;
    }

    void OnGUI()
    {
        float per1x = 65f;
        float per1y = 65f;
        float basex = 735f + per1x;
        float basey = 590f + per1y;

        if (this.step == CARD.STEP.ACTIVATE)
        {
            CardEffect cardeffect = GetComponentInParent<CardEffect>();
            int[,] position = cardeffect.A_1(); // ここで座標のみを受け取っているため受け取りもとで行っている作業を下でもしている
            int dice_x;
            int dice_y;
            for (int i = 0; i < position.GetLength(0); i++)
            {
                dice_x = position[i, 0];
                dice_y = position[i, 1];

                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "");
                if (activate_i == true)
                {
                    dice_step = DICE.STEP.TOUCHE;
                    var gameObj = GameObject.FindGameObjectsWithTag("DICE");
                    for (int j = 0; j < position.GetLength(0); j++) // A_1でtargetobjごと受け取っていれば同じことをせずに済んだ
                    {
                        Dice dice = gameObj[j].GetComponent<Dice>();
                        if (dice.x == dice_x && dice.y == dice_y)　// 再び座標と一致するオブジェクトを探している、後で絶対直す
                        {
                            DragObj dragObj = dice.GetComponent<DragObj>();
                            //dragObj.ddd();
                            dragObj.eee();
                            step = CARD.STEP.IDLE;
                        }
                    }
                }
            }
        }

        if (this.step == CARD.STEP.TOUCHE)
        {
            bool activate = GUI.Button(new Rect(400, 350, 100, 90), "発動");
            bool ret = GUI.Button(new Rect(700, 350, 100, 90), "戻る");
            //bool Ret = GUI.Button(new Rect(100, 0, 1000, 1500), "");

            if (activate == true)
            {
                Debug.Log("ACTIVATE BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
                GameObject gameObj = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameObj.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;

                /*
                Texture2D texture = Resources.Load("back_2") as Texture2D;
                Debug.Log("aaaa");
                Image img = GameObject.Find("Canvas/Player/Hand").GetComponent<Image>();
                Debug.Log("b");
                img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
                Debug.Log("c");
                */

                //graveyard.AAA();
                Card card = this.GetComponent<Card>();
                player.PushSettingCardOnFieldFromHand(card);

                if (card.type == (int)Type.REFLECT)
                {
                    sprite = Resources.Load<Sprite>("back_1");
                    image = this.GetComponent<Image>();
                    image.sprite = sprite;
                }
                // カード効果の発動
                else
                {
                    step = CARD.STEP.ACTIVATE;
                }
            }
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
            }
        }

        /*
        if (this.dice_step == DICE.STEP.TOUCHE)
        {
            // KomaAbleから必要なボタン数、ボタンの位置を調べて表示させる。
            // 必要な情報を辞書型で返してそれの個数分Lengthなどで大きさ取得してfor分を回せばいいのでは?

            //Dice dice = GetComponentInParent<Dice>();
            //Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();

            var gameObj = GameObject.FindGameObjectsWithTag("DICE");
            Dice dice = gameObj[0].GetComponent<Dice>();
            Dice_move1 dice_move1 = gameObj[0].GetComponent<Dice_move1>();


            //List<KomaMove> moves = new List<KomaMove>();
            int[,] moves = new int[4, 2];

            bool[] koma_able = new bool[4];
            float[,] koma_position = new float[4, 2];

            moves = dice_move1.GetMoves();

            Vector3 tmp = this.transform.position;

            //int i = 0;
            //foreach (KomaMove move in moves)
            //foreach (float move in moves)
            for (int i = 0; i < 4; i++)
            {
                //if (dice.x + move.x > 5 || dice.x + move.x < 1)
                if (dice.x + moves[i, 0] > 5 || dice.x + moves[i, 0] < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    //i++;
                    continue;
                }
                if (dice.y + moves[i, 1] > 5 || dice.y + moves[i, 1] < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    //i++;
                    continue;
                }
                if (dice.flag == true)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + moves[i, 0]), basey - 432f + per1y * (dice.y + moves[i, 1]), 66, 66), "");
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
                //i++;
            }

            if (koma_able[0] == true)
            {
                Debug.Log("0 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[0, 0], koma_position[0, 1], 0);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[0, 0];
                dice.y = dice.y + moves[0, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[0, 0]:" + koma_position[0, 0] + "koma_position[0, 1]:" + koma_position[0, 1]);
            }
            if (koma_able[1] == true)
            {
                Debug.Log("1 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[1, 0], koma_position[1, 1], 0);

                Debug.Log("tmp.x:" + tmp.x + "tmp.y" + tmp.y);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[1, 0];
                dice.y = dice.y + moves[1, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[1, 0]:" + koma_position[1, 0] + "koma_position[1, 1]:" + koma_position[1, 1]);
            }
            if (koma_able[2] == true)
            {
                Debug.Log("2 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[2, 0], koma_position[2, 1], 0);

                Debug.Log("tmp.x:" + tmp.x + "tmp.y" + tmp.y);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[2, 0];
                dice.y = dice.y + moves[2, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[2, 0]:" + koma_position[2, 0] + "koma_position[2, 1]:" + koma_position[2, 1]);
            }
            if (koma_able[3] == true)
            {
                Debug.Log("3 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[3, 0], koma_position[3, 1], 0);

                Debug.Log("tmp.x:" + tmp.x + "tmp.y" + tmp.y);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[3, 0];
                dice.y = dice.y + moves[3, 1];
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[3, 0]:" + koma_position[3, 0] + "koma_position[3, 1]:" + koma_position[3, 1]);
            }
        }
        */
    }
}
