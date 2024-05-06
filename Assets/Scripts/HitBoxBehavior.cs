using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxBehavior : MonoBehaviour
{

    private PlayerStats _playerStats;

    // Start is called before the first frame update
    void Start()
    {
        _playerStats = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        var hit = other.GetComponent<BoxCollider2D>();

        if (hit != null) {
            other.GetComponent<EnemyStats>().TakeDamage(4);
            Debug.Log("Evil Brother has been hit !");
        }
    }
}
