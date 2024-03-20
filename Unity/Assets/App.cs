using System;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


// 훈련생 : 노석현
// 날짜 : 2024-01-24
// 능력단위 : 게임 알고리즘

public class App : MonoBehaviour
{
    private void Start()
    {
        float[] tests = new float[] { 3f, 5f, 2f, 7f, 4f };
        float  max;
        Getmax(tests, out max);
        Debug.LogFormat($" Max : {max}");
    }
    void Getmax(float[] array, out float max)
    {
       
        max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
                max = array[i];
        }

    }
}
