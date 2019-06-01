using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    void Update()
    {
        
    }

    // 駒選択処理
    public void chooseKoma(string name)
    {
        Debug.Log(name);
        string[] names = name.Split(new char[] { '_' });
        string komaname = "yose5p_" + names[1];
        Debug.Log(komaname);
        GameObject komaObj = GameObject.Find(name);
        KomaScript sc = komaObj.GetComponent<KomaScript>();
        Debug.Log("sc.x:" + sc.x);
        Debug.Log("sc.y:" + sc.y);

        List<KomaMove> moves = new List<KomaMove>();
        Dice_move1 dice = new Dice_move1();
        moves = dice.GetMoves(sc);

        this.RefresAbles(sc, moves, name);
    }

    // 移動可能マスの表示
    public void RefresAbles(KomaScript sc, List<KomaMove> moves, string name)
    {
        GameObject refObj = GameObject.Find("ban2_1");
        BanScript banScript = refObj.GetComponent<BanScript>();
        float per1x = 50.6f;
        float per1y = 50.6f;
        float basex = 575f + per1x;
        float basey = 420f + per1y;
        List<KomaMove> choosemoves = new List<KomaMove>();
        if (!banScript.chooseflag)
        {
            int i = 0;
            foreach (KomaMove move in moves)
            {
                if (sc.x + move.x > 5 || sc.x + move.x < 1)
                {
                    continue;
                }
                if (sc.y + move.y > 5 || sc.y + move.y < 1)
                {
                    continue;
                }
                Sprite sp = Resources.Load<Sprite>("koma_able");
                GameObject gameObj = new GameObject();
                SpriteRenderer spriteRenderer = gameObj.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = sp;
                gameObj.transform.parent = FindObjectOfType<Canvas>().transform;
                gameObj.transform.localScale = new Vector3(14, 14, 0);
                gameObj.transform.name = "koma_able" + i;
                gameObj.transform.position = new Vector3(basex - per1x * (sc.x + move.x), basey - per1y * (sc.y + move.y), -2);
                BoxCollider2D box = gameObj.AddComponent<BoxCollider2D>() as BoxCollider2D;
                KomaAble komaAble = gameObj.AddComponent<KomaAble>();
                komaAble.x = sc.x + move.x;
                komaAble.y = sc.y + move.y;
                i++;
                choosemoves.Add(move);
            }
            banScript.chooseflag = true;
            banScript.choosemoves = choosemoves;
            banScript.choosekomaname = name;
        }
    }
}
