using UnityEngine;

public class Exerciciofuncao2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            mostrarmensagem();
        }
    }

    // Update is called once per frame
    void mostrarmensagem()
    {
        print("hello world");
    }
}
