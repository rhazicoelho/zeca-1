using UnityEngine;

public class Exerciciorepeticao_3 : MonoBehaviour
{
 
    void Start()
    {
        int numeros = 0;

        while (numeros < 20)
        {
            numeros++;

            if (numeros == numeros % 2)
            {
                print(numeros);
            }
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
