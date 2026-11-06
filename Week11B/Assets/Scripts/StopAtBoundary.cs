using UnityEngine;

public class StopAtBoundary : MonoBehaviour
{
    [SerializeField] private float boundaryX = 3f;

    private void LateUpdate()
    {
        if (transform.position.x >= boundaryX)
        {
            Vector3 position = transform.position;
            position.x = boundaryX;
            transform.position = position;

            GetComponent<TranslateObject>().Speed = 0f;
        }
    }
}