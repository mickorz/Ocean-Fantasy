﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RubbishMove : MonoBehaviour
{
    public int indexX = 0;
    public float CountDown = 0;
    public float indexY = 0;
    public float Speed = 8f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            CountDown -= Time.deltaTime;
            if (CountDown <= 0)
            {
                Move();
                CountDown = 4;
            }
        
    }
    void Move()
    {
        indexX = Random.Range(-5, 4);


        indexY = Random.Range(0.4f, -5.8f);
        Tweener fish = this.transform.DOMove(new Vector3(indexX, indexY, -2), Speed);
        fish.SetEase(Ease.Linear);

    }
  
}
