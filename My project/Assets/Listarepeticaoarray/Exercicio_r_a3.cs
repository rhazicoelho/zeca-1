using UnityEngine;

public class Exercicio_r_a3 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5] {1, 3, 10, 6, 7 };
    void Start()
    {
        int i = 0;
        
        while (i < numeros.Length)
        {
            print(numeros[i]);
            i++;
        }
    }

   
    void Update()
    {
        
    }
}
