using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    public PlayerController player;

    void Start()
    {
        InvokeRepeating("Spawn", 0 , 2.0f);
    }

    void Spawn()
    {
        if (!player.isGameOver)
        {
            var go = Instantiate(
                obstaclePrefab,
                spawnPoint.position,
                obstaclePrefab.transform.rotation
            );
            go.GetComponent<MoveLeft>().player = player;
        }
    }
}
