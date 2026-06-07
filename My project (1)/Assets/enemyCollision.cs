using UnityEngine;

public class CollisioneMacchina : MonoBehaviour
{
    private badEnding scriptBadEnding;

    void Start()
    {
        scriptBadEnding = FindObjectOfType<badEnding>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (scriptBadEnding != null)
            {
                scriptBadEnding.RiproduciMorte();
            }
        }
    }
}
