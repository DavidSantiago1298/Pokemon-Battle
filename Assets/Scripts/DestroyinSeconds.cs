using UnityEngine;

public class DestroyinSeconds : MonoBehaviour
{
    [SerializeField]

    private float _destroyAfterSeconds = 2f;

    private void Start()
    {
        Destroy(gameObject, _destroyAfterSeconds);
    }
}
