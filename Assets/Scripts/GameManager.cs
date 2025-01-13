using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int orbs = 0;
    public TextMeshProUGUI OrbText;
    // Start is called before the first frame update
    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
            Destroy (gameObject);
        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void OrbCollected()
    {
      orbs++;
      OrbText.text = "Coins "+ orbs;
    }
    public interface ICollectable
    {
        public void OnCollected();
    }
    
}
