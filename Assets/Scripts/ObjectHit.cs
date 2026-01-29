using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer Mesh;
    void CollisionTagging (Collision collision)
    {
        Mesh = GetComponent<MeshRenderer>();
        Mesh.material.color = Random.ColorHSV();
        gameObject.tag = "Hit";

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           CollisionTagging(collision);
        }
    }
}
