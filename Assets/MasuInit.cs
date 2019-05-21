using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasuInit : MonoBehaviour
{
    public int x;
    public int y;
    public string komaName; // 駒の種類
    public string objName; // 駒のオブジェクト名
    public bool exists = false; // 駒があればtrue, なければfalse
    public bool selfFlag = true; // 味方はtrue, 敵はfalse
    public bool enemyFlag = false; // 敵はtrue, その他はfalse
    public bool chooseflag = false;

    public static string dice1 = "yose5p_1";
    public static string dice2 = "yose5p_3";
    public static string dice3 = "yose5p_5";
    public static string dice4 = "yose5p_7";
    public static string dice5 = "yose5p_9";
    public static string dice6 = "yose5p_0";
    public static string dice7 = "yose5p_2";
    public static string dice8 = "yose5p_4";
    public static string dice9 = "yose5p_6";
    public static string dice10 = "yose5p_8";

    /*
    public string Init(int x, int y)
    {
        return null;
    }
    */
    public void Init(int s, int t)
    {
        x = s;
        y = t;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
