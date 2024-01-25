using DG.Tweening;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    private void Start()
    {
        transform.parent.TryGetComponent(out BoxSpawn spawnPoint);
        transform.DOMoveZ(spawnPoint.Distance, 1/spawnPoint.MoveSpeed).SetEase(Ease.Linear).OnComplete(() => Destroy(gameObject));
    }
}
