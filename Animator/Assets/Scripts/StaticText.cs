using UnityEngine;

public class StaticTest : MonoBehaviour
{
    void Start()
    {
        StaticEx c1 = gameObject.AddComponent<StaticEx>();
        StaticEx c2 = gameObject.AddComponent<StaticEx>();
    }
}
