using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public Animator anim;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D _rb;
    private PlayerStats _playerStats;
    private GameObject _enemy;
    private Vector3 _enemyPosition;
    private float _scaleX;
    private float _scaleY;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerStats = GetComponent<PlayerStats>();
        _enemy = GameManager.Instance.enemy;
        _scaleX = transform.localScale.x;
        _scaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {
            anim.SetTrigger("Jump");
            Jump();
        }

        if(_enemy != null) {
            _enemyPosition = _enemy.transform.position;
            Vector2 direction = transform.position - _enemyPosition;
            if(direction.x < 0) {
                transform.localScale = new Vector2(_scaleX, _scaleY);
            } else if (direction.x > 0) {
                transform.localScale = new Vector2(-_scaleX, _scaleY);
            }
        }

        anim.SetFloat("Speed", movement.x * _playerStats.speed);
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector2(movement.x * _playerStats.speed, _rb.velocity.y);    
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public void Jump()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, _playerStats.jumpPower);
    }
}
