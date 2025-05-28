using UnityEngine;

[ExecuteAlways]
public class ColliderGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.3f);
        if (TryGetComponent<BoxCollider>(out var box))
        {
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawCube(box.center, box.size);
        }
    }
}
