using UnityEngine;

public class DistanceInput : MonoBehaviour
{
    [field: SerializeField] public float Distance { get; private set; } = 20f;

    public void OnValueChanged(string input)
    {
        Distance = float.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
    }
}
