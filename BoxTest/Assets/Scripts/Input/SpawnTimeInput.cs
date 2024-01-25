using UnityEngine;

public class SpawnTimeInput : MonoBehaviour, IInput
{
    [field: SerializeField] public float SpawnTime { get; private set; } = 0.1f;

    public void OnValueChanged(string input)
    {
        SpawnTime = float.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
    }
}
