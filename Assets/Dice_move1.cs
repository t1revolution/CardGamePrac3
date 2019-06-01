using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_move1 : MonoBehaviour
{
    public List<KomaMove> GetMoves(bool reverse = false)
    {
        int reversenum = 1;
        if (reverse)
        {
            reversenum = -1;
        }

        List<KomaMove> moves = new List<KomaMove>();
        //KomaMove move = GetComponentInParent<KomaMove>();
        //KomaMove move = new KomaMove();

        int[] xs = { 1, -1, 0, 0 };
        int[] ys = { 0, 0, 1, -1 };
        int i = 0;
        foreach (int x in xs)
        {
            int y = ys[i];
            KomaMove move = new KomaMove();
            //KomaMove move = GetComponentInParent<KomaMove>();
            move.x = x;
            move.y = y * reversenum;
            moves.Add(move);
            i++;
        }

        /*
        List<KomaMove> moves = new List<KomaMove>();
        GameObject gameObj = new GameObject("able_masu");
        KomaMove move = gameObj.AddComponent<KomaMove>();
        move.x = 0;
        move.y = 1;
        moves.Add(move);
        KomaMove move2 = gameObj.AddComponent<KomaMove>();
        move2.x = 1;
        move2.y = 0;
        moves.Add(move2);
        KomaMove move3 = gameObj.AddComponent<KomaMove>();
        move3.x = 0;
        move3.y = -1;
        moves.Add(move3);
        KomaMove move4 = gameObj.AddComponent<KomaMove>();
        move4.x = -1;
        move4.y = 0;
        moves.Add(move4);
        */

        return moves;
    }
}



/*
// オブジェクトKomaMoveスクリプトが四つ格納されたオブジェクトが移動するごとに生成されてしまう
GameObject gameObj = new GameObject("able_masu");
KomaMove move = gameObj.AddComponent<KomaMove>();
move.x = 0;
move.y = 1;
moves.Add(move);
KomaMove move2 = gameObj.AddComponent<KomaMove>();
move2.x = 1;
move2.y = 0;
moves.Add(move2);
KomaMove move3 = gameObj.AddComponent<KomaMove>();
move3.x = 0;
move3.y = -1;
moves.Add(move3);
KomaMove move4 = gameObj.AddComponent<KomaMove>();
move4.x = -1;
move4.y = 0;
moves.Add(move4);
*/

/*
KomaMove move = new KomaMove();
move.x = 0;
move.y = 1;
moves.Add(move);
KomaMove move2 = new KomaMove();
move2.x = 1;
move2.y = 0;
moves.Add(move2);
KomaMove move3 = new KomaMove();
move3.x = 0;
move3.y = -1;
moves.Add(move3);
KomaMove move4 = new KomaMove();
move4.x = -1;
move4.y = 0;
moves.Add(move4);
*/
