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
        // char배열로 변경
        char temp;

        for(int i=0; i< (arr.Length/ 2); i++) // 앞쪽 절반만 돌아서 뒤쪽과 switcing
        {
            temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];   //arr.Length-1가 맨 뒤이고 -i만큼 앞쪽과 switcing
            arr[arr.Length - 1 - i] = temp;
        }
    } 
}
