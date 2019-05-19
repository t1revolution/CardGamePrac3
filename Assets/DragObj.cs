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

public class DragObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public CARD.STEP step = CARD.STEP.NONE;
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
            /*
            if (Ret == true)
            {
                Debug.Log("RETURN BUTTON WAS CLICKED!!!!!!");
                this.step = CARD.STEP.IDLE;
                this.transform.localScale = new Vector3(0.8f, 1.2f, 0.0f);
            }
            */
        }
    }
}
