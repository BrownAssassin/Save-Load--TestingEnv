using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpCountText : MonoBehaviour, IDataPersistence
{
    private int jumpCount = 0;
    private TextMeshProUGUI jumpCountText;

    private void Awake()
    {
        jumpCountText = this.GetComponent<TextMeshProUGUI>();
    }

    public void LoadData(GameData data)
    {
        this.jumpCount = data.jumpCount;
    }

    public void SaveData(ref GameData data)
    {
        data.jumpCount = this.jumpCount;
    }

    public void OnPlayerJump()
    {
        jumpCount++;
    }

    private void Update()
    {
        jumpCountText.text = "" + jumpCount;
    }
}
