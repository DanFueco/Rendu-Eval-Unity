using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;
    public GameObject enemy;

    void Awake() {
        if (Instance != null) 
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
