using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    [SerializeField] private float primeironumero = 17;
    [SerializeField] private float segundonumero = 4;
    void Start()
    {
        print("resultado da conta: " + (primeironumero % segundonumero));
    }

    
    void Update()
    {
        
    }
}
