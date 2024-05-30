using UnityEngine;

public class StaticEx : MonoBehaviour
{
    public static int count = 0;

    public void Start()
    {
        count++;
        Debug.Log(count);
    }
}