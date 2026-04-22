using NUnit.Framework.Constraints;
using UnityEngine;

public class Ex3_prepcp2 : MonoBehaviour
{
   int[] notas = new int[8];
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Random.Range(1,9);
                if (notas[i] >= 6)
                {
                    print(notas[i]);
                    print("passou");
                }
                else
                {
                    print(notas[i]);
                    print("reprovoado");
                }
            }
        }
    }
}
