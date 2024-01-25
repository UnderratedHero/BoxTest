using UnityEngine;

public class MoveSpeedInput : MonoBehaviour, IInput
{
    [field:SerializeField] public float MoveSpeed { get; private set; } = 0.2f;

    public void OnValueChanged(string input)
    {
        MoveSpeed = float.Parse(input, System.Globalization.CultureInfo.InvariantCulture);
    }
}
