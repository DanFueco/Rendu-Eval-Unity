using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private GameObject _player;
    private Vector3 _playerPosition;
    private float _scaleX;
    private float _scaleY;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameManager.Instance.player;
        _scaleX = transform.localScale.x;
        _scaleY = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        _playerPosition = _player.transform.position;
        Vector2 direction = transform.position - _playerPosition;
        if(direction.x < 0) {
            transform.localScale = new Vector2(_scaleX, _scaleY);
        } else if (direction.x > 0) {
            transform.localScale = new Vector2(-_scaleX, _scaleY);
        }
    }
}
