using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KomaScript : MonoBehaviour
{
    public int x;
    public int y;
    public string komaName; // 駒の種類
    public string objName; // 駒のオブジェクト名
    public bool exists = false; // 駒があればtrue, なければfalse
    public bool selfFlag = false; // 味方はtrue, 敵はfalse
    public bool enemyFlag = false; // 敵はtrue, その他はfalse
    public bool choseflag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetKoma(int x, int y, string objName)
    {
        string[] names = objName.Split(new char[] { '_' });
        string name = "yose5p_" + names[1];
        MasuInit detail = new MasuInit();
        detail.x = x;
        detail.y = y;
        detail.komaName = name;
        detail.objName = objName;
        detail.exists = true;
        if (int.Parse(names[4]) == 0)
        {
            detail.selfFlag = true;
            detail.enemyFlag = false;
            /*
            detail.selfFlag = false;
            detail.enemyFlag = true;
            */
        }
        else
        {
            detail.selfFlag = false;
            detail.enemyFlag = true;
            /*
            detail.selfFlag = true;
            detail.enemyFlag = false;
            */
        }
    }
}
