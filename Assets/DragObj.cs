using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CARD {
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        TOUCHE,
    };
}
public class DICE {
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        TOUCHE,
    };
}

public class DragObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
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

    void OnGUI()
    {
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
            }
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
            }
        }

        if (this.dice_step == DICE.STEP.TOUCHE)
        {
            // KomaAbleから必要なボタン数、ボタンの位置を調べて表示させる。
            // 必要な情報を辞書型で返してそれの個数分Lengthなどで大きさ取得してfor分を回せばいいのでは?
            Dice dice = GetComponentInParent<Dice>();
            Dice_move1 dice_move1 = GetComponentInParent<Dice_move1>();
            List<KomaMove> moves = new List<KomaMove>();
            bool[] koma_able = new bool[4];
            float[,] koma_position = new float[4,2];

            moves = dice_move1.GetMoves();

            float per1x = 65f;
            float per1y = 65f;
            float basex = 735f + per1x;
            float basey = 590f + per1y;

            Vector3 tmp = this.transform.position;

            int i = 0;
            foreach (KomaMove move in moves)
            {
                if (dice.x + move.x > 5 || dice.x + move.x < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    i++;
                    continue;
                }
                if (dice.y + move.y > 5 || dice.y + move.y < 1)
                {
                    koma_able[i] = false;
                    koma_position[i, 0] = 0.0f;
                    koma_position[i, 1] = 0.0f;
                    i++;
                    continue;
                }
                if (dice.flag == true)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + move.x), basey - 432f + per1y * (dice.y + move.y), 66, 66),"");
                    koma_position[i, 0] = basex - per1x * (dice.x + move.x);
                    koma_position[i, 1] = basey - per1y * (dice.y + move.y);
                    koma_able[i] = activate_i;
                }
                else if (dice.flag == false)
                {
                    bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice.x + move.x), basey - 432f + per1y * (dice.y + move.y), 66, 66), "");
                    koma_position[i, 0] = basex - per1x * (dice.x + move.x);
                    koma_position[i, 1] = basey - per1y * (dice.y + move.y);
                    koma_able[i] = activate_i;
                }
                i++;
            }

            if (koma_able[0] == true)
            {
                Debug.Log("0 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[0, 0], koma_position[0, 1], 0);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[0].x;
                dice.y = dice.y + moves[0].y;
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[0, 0]:" + koma_position[0, 0] + "koma_position[0, 1]:" + koma_position[0, 1]);
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
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[1, 0], koma_position[1, 1], 0);

                Debug.Log("tmp.x:" + tmp.x + "tmp.y" + tmp.y);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[1].x;
                dice.y = dice.y + moves[1].y;
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[1, 0]:" + koma_position[1, 0] + "koma_position[1, 1]:" + koma_position[1, 1]);
            }
            if (koma_able[2] == true)
            {
                Debug.Log("2 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[2, 0], koma_position[2, 1], 0);

                Debug.Log("tmp.x:" + tmp.x + "tmp.y" + tmp.y);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[2].x;
                dice.y = dice.y + moves[2].y;
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[2, 0]:" + koma_position[2, 0] + "koma_position[2, 1]:" + koma_position[2, 1]);
            }
            if (koma_able[3] == true)
            {
                Debug.Log("3 BUTTON WAS CLICKED!!!!!!");

                this.dice_step = DICE.STEP.NONE;
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.0f);
                this.transform.position = new Vector3(koma_position[3, 0], koma_position[3, 1], 0);

                Debug.Log("tmp.x:" + tmp.x + "tmp.y" + tmp.y);

                Debug.Log("x:" + dice.x + "y:" + dice.y);
                dice.x = dice.x + moves[3].x;
                dice.y = dice.y + moves[3].y;
                Debug.Log("x:" + dice.x + "y:" + dice.y);
                Debug.Log("koma_position[3, 0]:" + koma_position[3, 0] + "koma_position[3, 1]:" + koma_position[3, 1]);
            }
        }
    }
}
