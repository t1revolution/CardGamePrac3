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
        ACTIVATE,　// カードがDiceを対象にとる効果
        EXPAND,
        CHECK,
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
    public CARD.STEP step = CARD.STEP.NONE;
    public DICE.STEP dice_step = DICE.STEP.NONE;
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
        this.transform.localScale = new Vector3(1.0f, 1.5f, 0.0f);
        this.step = CARD.STEP.TOUCHE;
    }
    public void DiceAction()
    {
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

        /*
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
                    //dice_step = DICE.STEP.TOUCHE;
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
        */

        if (this.step == CARD.STEP.TOUCHE)
        {
            bool activate = GUI.Button(new Rect(400, 350, 100, 90), "発動");
            bool ret = GUI.Button(new Rect(700, 350, 100, 90), "戻る");

            if (activate == true)
            {
                Debug.Log("ACTIVATE BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                //this.step = CARD.STEP.EXPAND;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
                GameObject gameObj = GameObject.Find("GameMaster");
                GameMaster gamemaster = gameObj.GetComponent<GameMaster>();
                player1 player = gamemaster.currentPlayer;

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
                    Card cardObj = GetComponentInParent<Card>();
                    CardEffect cardeffectObj = GetComponentInParent<CardEffect>();
                    cardeffectObj.Activate(cardObj);
                }
            }
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
            }
        }
        else if (this.step == CARD.STEP.EXPAND)
        {
            bool activate = GUI.Button(new Rect(400, 350, 100, 90), "確認");
            bool ret = GUI.Button(new Rect(700, 350, 100, 90), "戻る");
            if (activate == true)
            {
                Debug.Log("CHECK BUTTON WAS CLICKED!!!!!!");
                this.transform.localScale = new Vector3(8f, 12f, -3f);
                this.step = CARD.STEP.CHECK;
            }
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
            }
        }
        else if (this.step == CARD.STEP.CHECK)
        {
            bool ret = GUI.Button(new Rect(550, 350, 100, 90), "戻る");
            if (ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
            }
        }
    }
}