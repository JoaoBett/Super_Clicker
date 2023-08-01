using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public Text enemyLifeText;

    // Update is called once per frame
    void Update()
    {
        NewEnemy();
        enemyLifeText.text = $"HP: {GameManager.enemyLife}";
    }

    public void DecrementEnemyLife()
    {
        GameManager.enemyLife -= GameManager.heroStrength;
    }

    public void NewEnemy()
    {
        if(GameManager.enemyLife == 0)
        {
            GameManager.enemyLife = 10;
        }
    }
}
