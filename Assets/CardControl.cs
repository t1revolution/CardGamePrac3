// カードのタップに関する処理を実装しようとしてQIITAの記事に乗っていたものを乗せただけ
// cubeの生成について書いてるからまあ、いらん

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CardControl : MonoBehaviour
{

    Rigidbody rigidBody;
    public Vector3 force = new Vector3(0, 10, 0);
    public ForceMode forceMode = ForceMode.VelocityChange;

    // Use this for initialization
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();

    }
    public void OnUserAction()
    {
        rigidBody.AddForce(force, forceMode);
    }
}