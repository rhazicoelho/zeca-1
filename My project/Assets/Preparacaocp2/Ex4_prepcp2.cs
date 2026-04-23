using UnityEngine;

public class Ex4_prepcp2 : MonoBehaviour
{




    void Start()
    {
        int n = 1;
        int pares = 0;

        while (n <= 20)
        {
            if (n % 2 == 0)
            {
                pares++;
            }

            print(n);
            n++;
        }

        print("Quantidade de pares: " + pares);




    }


    void Update()
    {
        
    }
}
