using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CARDEFFECT
{
    public enum STEP
    {
        NONE = -1,
        IDLE = 0,
        ACTIVATE,
    };
}

public class CardEffect : MonoBehaviour
{
    CARDEFFECT.STEP step = CARDEFFECT.STEP.NONE;
    /*
    public void Activate() {
        A_1();
        //step = CARDEFFECT.STEP.ACTIVATE;
    }
    */
    public int[,] A_1()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();
        
        return position;
    }
    public int[,] A_2()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();
        
        return position;
    }
    public int[,] A_3()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();
        
        return position;
    }
    public int[,] A_4()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();
        
        return position;
    }
    public int[,] A_5()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();
        
        return position;
    }
    public int[,] A_6()
    {
        int a;
        a = Getdiceposition().GetLength(0);
        int[,] position = new int[a, 2];
        position = Getdiceposition();
        
        return position;
    }

    int[,] Getdiceposition()
    {
        var targets = GameObject.FindGameObjectsWithTag("DICE");
        int[,] position = new int[targets.Length, 2];
        int i = 0;
        foreach (GameObject target in targets)
        {
            position[i, 0] = target.GetComponent<Dice>().x;
            position[i, 1] = target.GetComponent<Dice>().y;
            i++;
        }
        return position;
    }

    /*
    void OnGUI()
    {
        if (step == CARDEFFECT.STEP.ACTIVATE)
        {
            step = CARDEFFECT.STEP.IDLE;
            int[,] position = A_1();
            float per1x = 65f;
            float per1y = 65f;
            float basex = 735f + per1x;
            float basey = 590f + per1y;
            int dice_x;
            int dice_y;
            for (int i = 0; i < position.GetLength(0); i++)
            {
                dice_x = position[i, 0];
                dice_y = position[i, 1];
                bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 10366, 10366), "aaaaa");
                //bool activate_i = GUI.Button(new Rect(basex - 33f - per1x * (dice_x), basey - 432f + per1y * (dice_y), 66, 66), "aaaaa");
                //koma_position[i, 0] = basex - per1x * (dice.x + moves[i, 0]);
                //koma_position[i, 1] = basey - per1y * (dice.y + moves[i, 1]);
            }
        }
    }
    */
}