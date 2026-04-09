using UnityEngine;

public class Exerciciorepeticao_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numeros = 0;

        while (numeros < 10)
        {
            numeros++;
            print(numeros);
        }
        print("fim");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
