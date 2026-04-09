using UnityEngine;

public class Exerciciorepeticao_5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int vida = 101;
        int moedas = 0;

        while (vida > 100)
        {
            vida--;
            print("jodador ainda vivo com " + vida + "de vida");

            while (moedas < 10)
            {
                moedas++;
                if (moedas == 5)
                {
                    print("metade do caminho!");
                }
                else if (moedas == 10)
                {
                    vida++;
                    print("1 de vida recebido por ter 10 moedas");
                    moedas = 0;
                }
            }
            if (vida == 0)
            {
                print("GAME OVER");
                break;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
