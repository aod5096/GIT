using System;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;


// �Ʒû� : �뼮��
// ��¥ : 2024-01-24
// �ɷ´��� : ���� �˰���

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
