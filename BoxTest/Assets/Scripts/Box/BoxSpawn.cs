using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    [SerializeField] private BoxMove _prefab;
    [SerializeField] private SpawnTimeInput _spawnTimeInput;
    [SerializeField] private DistanceInput _distanceInput;
    [SerializeField] private MoveSpeedInput _moveSpeedInput;
    private Timer _timer;
    public float Distance { get { return _distanceInput.Distance; } }
    public float MoveSpeed { get { return _moveSpeedInput.MoveSpeed; } }

    private void Start()
    {
       _timer = new Timer(_spawnTimeInput.SpawnTime, endAction: Spawn);
       StartCoroutine(_timer.Start());
    }

    private void Spawn()
    {
        Instantiate(_prefab,transform);
        StartCoroutine(_timer.Start());
    }
}
