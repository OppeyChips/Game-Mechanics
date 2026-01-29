using UnityEngine;
using UnityEngine.Rendering;

public class FlyAtPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
[SerializeField] Transform Player;

[SerializeField] float timeOfFloat = 0.4f;



Vector3 playerPosition;

    void Start()
    {
        playerPosition = Player.position;
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, timeOfFloat);
    }

    void DestoryBalls()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        MoveTowardsPlayer();
        DestoryBalls();
    }
}
