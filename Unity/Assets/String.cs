using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class String : MonoBehaviour
{
    private void Start()
    {
        string input = "Hello";

        char[] arr = input.ToCharArray();

        Reverse(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }


     void Reverse(char[] arr) // Switching
    {
        // char�迭�� ����
        char temp;

        for(int i=0; i< (arr.Length/ 2); i++) // ���� ���ݸ� ���Ƽ� ���ʰ� switcing
        {
            temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];   //arr.Length-1�� �� ���̰� -i��ŭ ���ʰ� switcing
            arr[arr.Length - 1 - i] = temp;
        }
    } 
}
