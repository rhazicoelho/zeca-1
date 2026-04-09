using UnityEngine;

public class Exerciciorepeticao_4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numero = 0;
        while (numero < 100)
        {
            numero++;
            print(numero);
            if (numero == 7)
            {
                print("numero encontrado");
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
