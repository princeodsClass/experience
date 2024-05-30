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
            Debug.Log("���̴� 18�� �̻��̾�� �մϴ�.");
        }
        finally
        { Debug.Log("���� ��ȿ�� �˻� �Ϸ�."); }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
            throw new Exception("���̰� ��ȿ���� �ʽ��ϴ�.");

        Debug.Log("���̰� ��ȿ�մϴ�.");
    }
}