using UnityEngine;

public class Exercicio17 : MonoBehaviour
{
    // deveria ter posto quantia com serialized (mudavel) e ter deixado valor "imutavel", teria sido mais lógico
    [SerializeField] private int moedabronze = 1;
    [SerializeField] private int moedaprata = 5;
    [SerializeField] private int moedaouro = 10;
    private int valorbronze;
    private int valorprata;
    private int valorouro;
    private int valorsacomoedas;
    void Start()
    {
        valorbronze = moedabronze * 12;
        valorprata = moedaprata * 8;
        valorouro = moedaouro * 3;
        valorsacomoedas = valorbronze + valorprata + valorouro;
        print("ao receber um saco de moedas, o personajem conta 12 moedas de bronze com valor de= " + (valorbronze)  + ", 8 moeadas de prata valendo= " + (valorprata) + ",e 3 moedas de ouro valendo= " + (valorouro));
        print("valor total do saco de moeadas é= " + valorsacomoedas);
    }

    
    void Update()
    {
        
    }
}
