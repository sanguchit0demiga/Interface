using UnityEngine;

public class Enemy : MonoBehaviour, Ipresentation
{
    public ScriptableEnemy enemyData;
    public void Accion()
    {
        enemyData.Accion();
    }
}
