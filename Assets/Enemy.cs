using UnityEngine;

public class Enemy : MonoBehaviour, Ipresentation, ITakeDamage
{
    public int vida = 100;
    public ScriptableEnemy enemyData;

    public void TakeDamage(int damage)
    {
        vida -= damage;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

   

  
    public void Accion()
    {
        enemyData.Accion();
    }

}
