using UnityEngine;

public class Exlistalivre_1 : MonoBehaviour
{
    string[] inventario = new string[] {"espada", "arco", "escudo", "poção", "anél" };
    void Start()
    {
        foreach (var item in inventario)
        {
            print(item.ToUpper());
        }
    }

   
    void Update()
    {
        
    }
}
