using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    bool hasDropped = false;
    [SerializeField] float DropTime = 5f;

    Rigidbody Rb;

    void DropItem()
    {
        Rb = GetComponent<Rigidbody>();
        Rb.useGravity = true;
        hasDropped = true;
    }

    void Start()
    {
        Rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > DropTime && hasDropped == false)
        {
            DropItem();
        }
    }
}