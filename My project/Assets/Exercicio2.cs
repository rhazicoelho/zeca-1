using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    [SerializeField] private int vida = 100;
    [SerializeField] private int dano = 25;
    void Start()
    {
        print("vida restante= " + (vida - dano));
    }
    
    void Update()
    {
        
    }
}
