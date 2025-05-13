using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;
    public float rangoInteraccion = 2f;
    private Enemy masCercano;


    void Update()
    {
        float movimientoX = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            movimientoX = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movimientoX = -1f;
        }

        transform.Translate(Vector2.right * movimientoX * velocidad * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.R))
        {
            NearestEnemy();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            KillEnemy();
        }
    }

    void NearestEnemy()
    {
        Enemy[] enemigos = FindObjectsOfType<Enemy>();
     
        float menorDistancia = Mathf.Infinity;

        foreach (Enemy enemigo in enemigos)
        {
            float distancia = Vector2.Distance(transform.position, enemigo.transform.position);
            if (distancia < menorDistancia && distancia <= rangoInteraccion)
            {
                menorDistancia = distancia;
                masCercano = enemigo;
            }
        }

        if (masCercano != null)
        {
            masCercano.Accion();
        }
        else
        {
            Debug.Log("No hay enemigos cerca para interactuar.");
        }
    }
        void KillEnemy()
        {
        if (Input.GetKeyDown(KeyCode.E) && masCercano != null && masCercano.vida > 0)
        {
            Debug.Log("Atacando a " + masCercano.name);
            masCercano.TakeDamage(1);
            }
        }
    }

      
 

       

    

