using UnityEngine;

public class Ex1_prepcp2 : MonoBehaviour
{
    int[] numeros = new int[10];
    
    
    void Start()
    {
      
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Random.Range(1, 101);

                if (numeros[i] % 2 == 0)
                {
                    
                    print(numeros[i]);
                }
                
            }
            
                
            
        }
    }
}
