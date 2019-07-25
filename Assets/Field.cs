using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FIELD
{
    public enum STATUS
    {
        NONE = 0,
        SET,
        ACTIVATED,
    };
    public enum NUMBER
    {
        NONE = 0,
        ONE,
        TWO,
        THEREE,
        FOUR,
    };
    public enum TYPE
    {
        ATTACK,
        SUPPORT,
        REFLECT,
        MANA,
    };
}

public class Field : MonoBehaviour
{
    public FIELD.STATUS status = FIELD.STATUS.NONE;
    public FIELD.NUMBER number = FIELD.NUMBER.NONE;
    public List<Card> cardList = new List<Card>();
    //public int num = 0;

    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform);
        cardList.Add(_card);
        //num = cardList.Count();
    }
    /*
    public Card Sweep()
    {
        for (int i = 0; i <= cardList.Length(); i++)
        {
            Card card = cardList[i];
            cardList.Remove(card);
            num = cardList.Count();
            return card;
        }
    }
    */
    public Card Pull(int _position)
    {
        Card card = cardList[_position];
        cardList.Remove(card);
        //num = cardList.Count();
        return card;
    }
    public Card Pull(Card _card)
    {
        cardList.Remove(_card);
        //num = cardList.Count();
        return _card;
    }
    public Card Get(int _position)
    {
        return cardList[_position];
    }

    public int Get_setcard_num()
    {
        int setcard_num = 0;
        foreach(Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.type == (int)CardObj.Type.REFLECT)
            {
                setcard_num += 1;
            }
        }
        return setcard_num;
    }

    public int GetS_2()
    {
        int S2_num = 0;
        foreach(Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                S2_num += 1;
            }
        }
        return S2_num;
    }

    public int GetS_2_activate()
    {
        int S2_num = 0;
        foreach(Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                if (card.activate == true)
                {
                    S2_num += 1;
                }
            }
        }
        return S2_num;
    }

    public int GetS_2_selected()
    {
        int S2_num = 0;
        foreach(Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                if (card.selected == true)
                {
                    S2_num += 1;
                }
            }
        }
        return S2_num;
    }

    public void GetS_2activate_true()
    {
        foreach (Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                if (card.activate == false)
                {
                    card.activate = true;
                    break;
                }
            }
        }
    }

    public void GetS_2selected_true()
    {
        foreach (Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                if (card.selected == false)
                {
                    card.selected = true;
                    break;
                }
            }
        }
    }

    public void GetS_2activate_restore()
    {
        foreach(Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                card.activate = false;
            }
        }
    }

    public void GetS_2selected_restore()
    {
        foreach(Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.name == "S_2")
            {
                card.selected = false;
            }
        }
    }

    public List<GameObject> Get_opp_setcardList()
    {
        List<GameObject> opp_setcard_list = new List<GameObject>();
        foreach (Transform child in transform)
        {
            Card card = child.GetComponent<Card>();
            CardObj cardObj = child.GetComponent<CardObj>();
            if (card.type == (int)FIELD.TYPE.REFLECT)
            {
                opp_setcard_list.Add(child.gameObject);
            }
        }
        return opp_setcard_list;
    }
}
