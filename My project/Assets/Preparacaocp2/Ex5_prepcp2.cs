using UnityEngine;

public class Ex5_prepcp2 : MonoBehaviour
{

    [SerializeField] private int numero;

    void Start()
    {
        
            bool primo = true;

            int aux = numero - 1;

            while (aux > 1)
            {
                if (numero % aux == 0)
                {
                    primo = false;
                    break;
                }




                aux++;
            }
            if (primo == true)
            {
                print(numero + "é primo");
            }
            else
            {
                print(numero + "não é primo");
            }
        

    }


    void Update()
    {
        
    }
}
