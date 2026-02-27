using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    public PlayerController player;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.isGameOver)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
