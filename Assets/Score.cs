using UnityEngine;
using TMPro;

public class HeightCounter : MonoBehaviour
{
    public Transform player;
    public TMP_Text heightText;

    private float maxHeight = 0f;

    void Update()
    {
        if (player.position.y > maxHeight)
        {
            maxHeight = player.position.y;
        }

        heightText.text = "Height: " + Mathf.FloorToInt(maxHeight);
    }
}
