using UnityEngine;

public class Exercicio16 : MonoBehaviour
{
    [SerializeField] private int parte1temp = 12;
    [SerializeField] private int parte2temp = 18;
    [SerializeField] private int parte3temp = 9;
    private int tempototal;
    void Start()
    {
        tempototal = parte1temp + parte2temp + parte3temp;
        print("tempo gasto na parte 1= " + parte1temp + "minutos," + "tempo gasto na parte 2= " + parte2temp + "minutos," + " minutos gastos na parte 3= " + parte3temp + "minutos," + " tempo total gasto em fase= " + tempototal + "minutos.");
    }

    
    void Update()
    {
        
    }
}
