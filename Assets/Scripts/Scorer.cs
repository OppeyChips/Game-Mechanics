using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    MeshRenderer Mesh;

    void OnCollisionEnter(Collision collision)
    {
        Mesh = GetComponent<MeshRenderer>();
        Mesh.material.color = Random.ColorHSV();
        hits++;
    }
}
