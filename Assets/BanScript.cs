﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanScript : MonoBehaviour
{
    public bool chooseflag = false;
    public List<KomaMove> choosemoves = new List<KomaMove>();
    public string choosekomaname;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DelChooseMoves()
    {
        if (chooseflag)
        {
            int i = 0;
            if (choosemoves != null && choosemoves.Count > 0)
            {
                foreach (KomaMove move in choosemoves)
                {
                    GameObject obj = transform.Find("../koma_able" + i).gameObject;
                    chooseflag = false;
                    Destroy(obj);
                    i++;
                }
            }
        }
    }
}
