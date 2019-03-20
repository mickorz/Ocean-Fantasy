﻿using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RubbishManager : MonoBehaviour
{
   
    private float Left = -28;
    private float Right = 28;
    private float high = 3.8f;
    private float low = -3.8f;
    public GameObject[] RubbishArray;
    private List<Vector2> positionList = new List<Vector2>();
    private Transform RubbishHolder;

    public float CountDown = 3;
    private float Num = 10;

    private float Speed = 3;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Num>=0)
        { CountDown -= Time.deltaTime;
        if (CountDown <=0)
        {
            CreateRubbish();
            Num--;
            CountDown = Speed;
            return;
        }

        }
    }

    public void CreateRubbish()
    {
        int indexX = Random.Range(-1, 1);
       
        float indexY = Random.Range(low, high);
        int index = Random.Range(0, RubbishArray.Length);
        if (indexX >= 0)
        {
            GameObject go = GameObject.Instantiate(RubbishArray[index], new Vector3(Right, indexY, 0), Quaternion.identity) as GameObject;
          Rigidbody rigidbody = go.GetComponent<Rigidbody>();
        rigidbody.velocity=new Vector3(-10,0,0);
        Destroy(go.gameObject,8f);
        }
        else
        {
            GameObject go = GameObject.Instantiate(RubbishArray[index], new Vector3(Left, indexY, 0), Quaternion.identity) as GameObject;
            Rigidbody rigidbody = go.GetComponent<Rigidbody>();
            rigidbody.velocity = new Vector3(10, 0, 0);
            Destroy(go.gameObject, 8f);
        }
         

    }

    public void Initialize(int num, int speed )
    {
        Num = num;
        Speed = speed;
    }
}

