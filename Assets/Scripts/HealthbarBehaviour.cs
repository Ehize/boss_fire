using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "HealthbarBehaviour", menuName = "Healthbar")]
public class HealthbarBehaviour : ScriptableObject
{
    public int health = 100;
    
    [SerializeField]
    private int maxHealth = 100;

    [System.NonSerialized]
    public UnityEvent<int> healthChangeEvent;

    private void OnEnable() {
        health = maxHealth;
        if (healthChangeEvent == null)
        healthChangeEvent = new UnityEvent<int>();
    }

    public void DecreaseHealth(int amount) {
        health -= amount;
        healthChangeEvent.Invoke(health);
    }
}
