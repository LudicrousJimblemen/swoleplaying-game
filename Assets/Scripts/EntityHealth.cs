using UnityEngine;

public class EntityHealth : MonoBehaviour {
    [SerializeField] private int maxHealth;
    public int Health { get; private set; }

    public void Awake() {
        Health = maxHealth;
    }

    public void IncrementHealth(int amount) {
        Health = Mathf.Clamp(Health + amount, 0, int.MaxValue);
    }
}
