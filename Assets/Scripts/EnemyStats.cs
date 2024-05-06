using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public Animator anim;
    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            Debug.Log("Evil Brother has died !");
            Die();
        }
    }

    public void TakeDamage(int damage) {
        anim.SetTrigger("Hurt");
        currentHealth -= damage;
        Debug.Log(currentHealth);
    }

    private void Die() {
        Destroy(gameObject);
    }
}
