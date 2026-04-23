using UnityEngine;

public class Ex10_prepcp2 : MonoBehaviour
{
    int moedas = 150;
    string[] itens = new string[] { "0 -espada $10", "1 -armadura $30", "2 -poção $200", "3 -escudo $300" };
   [SerializeField] int itemescolhido;
    void Start()
    {
       

        print("moeada: " + moedas);

        print("itens da loja");
        foreach (var item in itens)
        {
            print(item);
        }
    }

    
    void Update()
    {
        if (Input.anyKeyDown && (itemescolhido >=0 && itemescolhido<=3))
        {

            if (itemescolhido == 0 && moedas >= 10)
            {
                print(itens[0]);
            }

            else if (itemescolhido == 1 && moedas >= 30)
            {
                
            }
            else if (itemescolhido == 2 && moedas >= 200)
            {
                
            }
            else if (itemescolhido == 3 && moedas >= 300)
            {
                
            }

        }
        else
        {
            print("item não existe");
        }
    }
}
