using UnityEditor;
using UnityEngine;

public class Exerciciofuncao3 : MonoBehaviour
{
    [SerializeField] private string personagem;

    
    void Start()
    {
        mostrarpersonagem();
    }

    
    void mostrarpersonagem(string nome)
    {
        print ("personagem criado: " +  nome.ToUpper());
    }
}
