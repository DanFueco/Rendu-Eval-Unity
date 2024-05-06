using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float speed = 6.0f;
    public float jumpPower = 15.0f;
    public int atkDamage;

    private int _punchDamage = 4;
    private int _kickDamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UsePunch() {
        atkDamage = _punchDamage;
    }

    public void UseKick() {
        atkDamage = _kickDamage;
    }
}
