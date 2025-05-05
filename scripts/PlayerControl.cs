using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float moveSpeed = 5f;
    public int CurrentHealth = 30;
    public int MaxHealth = 30;

    public event System.Action OnHealthChange;

    public void TakeDamage(int damage)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - damage, 0);
        OnHealthChange?.Invoke();
    }

    public void Heal(int amount)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth);
        OnHealthChange?.Invoke();
    }

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = 0f;

        transform.Translate(xValue, yValue, zValue);
    }
}
