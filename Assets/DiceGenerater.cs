using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceGenerater : MonoBehaviour
{
    private Image image;
    private Sprite sprite;
    public GameObject dicePrefab;

    public void Generate(List<DiceData> _diceDataList)
    {
        float per1x = 65f;
        float per1y = 65f;
        float basex = 690f + per1x;
        float basey = 590f + per1y;
        /*
        float basex = 335f + per1x;
        float basey = 340f + per1y;
        */
        Vector3 komaScale = new Vector3(0.5f, 0.5f, 0);
        Quaternion komaRotation = new Quaternion(0, 0, 180, 0);

        for (int i = 0; i < _diceDataList.Count; i++)
        {
            GameObject diceObj = Instantiate(dicePrefab);
            diceObj.name = _diceDataList[i].name;

            int x = _diceDataList[i].x;
            int y = _diceDataList[i].y;
            bool flag = _diceDataList[i].flag;
            diceObj.transform.parent = FindObjectOfType<Canvas>().transform;
            diceObj.transform.localScale = komaScale;
            diceObj.transform.position = new Vector3(basex - per1x * x, basey - per1y * y, 0);
            if (!flag)
            {
                diceObj.transform.rotation = komaRotation;
                //gameObj.transform.name = objName;
            }
            Dice dice = diceObj.GetComponent<Dice>();
            dice.Load(_diceDataList[i]);
            //_dice.Add(dice);

            /*
            sprite = Resources.Load<Sprite>(dice.name);
            image = dice.GetComponent<Image>();
            image.sprite = sprite;
            */
        }
    }
}
