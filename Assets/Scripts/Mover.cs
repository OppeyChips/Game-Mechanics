using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] float speed = 5f;

    void PlayerMovement()
    {
        float XValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float ZValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(XValue, 0, ZValue);
    }

    void Update()
    {
        PlayerMovement();
    }
}
