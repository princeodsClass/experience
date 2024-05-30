using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{
    void Start()
    {
        int[] numbers = { 1, 2, 3 };

        try
        { ValidateAge(15); }
        catch (Exception ex)
        {
            Debug.LogException(ex);
            Debug.Log(ex);
            Debug.Log("나이는 18세 이상이어야 합니다.");
        }
        finally
        { Debug.Log("나이 유효성 검사 완료."); }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
            throw new Exception("나이가 유효하지 않습니다.");

        Debug.Log("나이가 유효합니다.");
    }
}