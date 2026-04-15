using UnityEngine;

public class Exercicio_r_a1 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int [5];
    
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
