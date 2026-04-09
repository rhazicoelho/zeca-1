using UnityEngine;

public class Exerciciorepeticao_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numeros = 10;

        while (numeros > 0)
        {
            numeros--;
            print(numeros);
        }
        print("BOOM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
