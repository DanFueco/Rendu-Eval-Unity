using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator anim;
    
    private PlayerBehavior _playerBehavior;
    private PlayerStats _playerStats;

    // Start is called before the first frame update
    void Start()
    {
        _playerBehavior = GetComponent<PlayerBehavior>();
        _playerStats = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            PunchAttack();
        } else if(Input.GetKeyDown(KeyCode.R) && Input.GetKey(KeyCode.UpArrow) && _playerBehavior.IsGrounded()) {
            JumpedAttack();
        } else if(Input.GetKeyDown(KeyCode.F)) {
            Ult();
        } else if(Input.GetKeyDown(KeyCode.R)) {
            KickAttack();
        }
    }

    void PunchAttack()
    {
        _playerStats.UsePunch();
        anim.SetTrigger("Punch_Attack");
    }

    void KickAttack()
    {
        _playerStats.UseKick();
        anim.SetTrigger("Kick_Attack");
    }

    void JumpedAttack()
    {
        _playerStats.UseKick();
        anim.SetTrigger("Jumped_Attack");
        _playerBehavior.Jump();
    }

    void Ult()
    {
        anim.SetTrigger("Ult_Attack");
    }
}
