using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Scriptable Objects/ScriptableEnemy")]
public class ScriptableEnemy : ScriptableObject, Ipresentation
{
 
    [SerializeField] public string name;
    [SerializeField] public int health;
    [SerializeField] public string greeting;

    public void Accion()
    {
        Debug.Log(greeting + name + " and I have " + health + " health points.");
    }
}
