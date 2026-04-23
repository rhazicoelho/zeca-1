using UnityEngine;

public class Ex7_prepcp2 : MonoBehaviour
{
    [SerializeField] private string nomeheroi;
    string[] itens = new string[] {"espada", "escudo", "arco", "adaga", "bomba"};

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            print(nomeheroi.ToUpper());
            print(nomeheroi.ToLower());

            foreach (var list in itens)
            {
                print("você tem: " + list + " em seu inventario");
            }
        }
    }
}
