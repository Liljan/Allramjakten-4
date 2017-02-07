using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject player;
    public Transform currentSpawnPoint;

    private int lives = 3;

	// Use this for initialization
	void Start () {
        Instantiate(player, currentSpawnPoint.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		if(lives < 0)
        {
            Debug.Log("Game Över!");
        }
	}

    public void Respawn()
    {
        Instantiate(player, currentSpawnPoint.position, Quaternion.identity);
    }

    public void AddLife() { ++lives; }
    public void RemoveLife() { --lives; }
}
