//CRIANDO SCRIPT DE ATAQUE NA PORTA
//ANIMAÇÃO DE BARRA DE VIDA DESCENDO

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoorDamage : MonoBehaviour
{
    int lifeChange;
    public Transform lifeBar;


    void Start()
    {
        lifeChange = GetComponent<Character>().life;  
    }


    void Update()
    {
        if(lifeChange != GetComponent<Character>().life)
        {
            lifeChange = GetComponent<Character>().life;
            GetComponent<Character>().skin.GetComponent<Animator>().Play("EnemyDoorDamage", -1);
        }
        
        if(GetComponent<Character>().life <= 0)
        {
            Destroy(gameObject);
        }

        lifeBar.localScale = new Vector3( (1 * GetComponent<Character>().life) / 15f, 1, 1);

    }
}
