using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    [SerializeField] private int numero = 20;
    void Start()
    {
        print("dobro: " + (numero * 2));
        print("metade: " +  (numero / 2));
    }

    
    void Update()
    {
        
    }
}
