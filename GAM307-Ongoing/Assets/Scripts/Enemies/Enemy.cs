﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum EnemyType
{
    Kobold,
    Kraken,
    Cthulu,
    SkeletonWarrior,
    Rattata,
}



public class Enemy : MonoBehaviour {

    public EnemyType enemyType;

    [Header("General")] // list things like health into a heading in the inspector
    public int health;
    public int speed;
    public int scoreValue;

    [Header("Traits")]
    public int attack;
    public int defence;

    [Header("UI Elements")]
    public TextMeshProUGUI healthUI;
    public Image healthBar;

    public float healthBarSections;


	
	void Start ()
    {
        EnemyManager.instance.enemyCount++;
         
        
        
	}

    public void GotHit(int baseDamage)
    {
        health -= baseDamage;

        healthUI.text = "Health: " + health.ToString();

        Vector3 temp = healthBar.transform.localScale;
        //temp.x = healthBarSections;

        GameEvents.ReportOnEnemyHit(enemyType, scoreValue);

        if (health <= 0)
            StartCoroutine(Die());
        
    }

    IEnumerator Die()
    {
        GetComponent<Collider>().enabled = false;

        for (float f = 1f; f >= 0; f -= 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = f;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }

        GameEvents.ReportOnEnemyDie();

        //EnemyManager.instance.enemyCount--;
        //EnemyManager.instance.SpawnEnemy();
        //GameManager.instance.AddScore(100);
        //AudioManage.PlaytSound()
        //ParticleManage.PlaySound
        //Play animation()
        Destroy(this.gameObject);
    }


    private void OnEnable()
    {
        GameEvents.OnDifficultyChange += OnDifficultyChange;
    }

    private void OnDisable()
    {
        GameEvents.OnDifficultyChange -= OnDifficultyChange;
    }

    void OnDifficultyChange(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.EASY:
                GetComponent<Renderer>().material.color = Color.green;
                transform.localScale = new Vector3(3, 3, 3);
                break;
            case Difficulty.MEDIUM:
                GetComponent<Renderer>().material.color = Color.blue;
                transform.localScale = new Vector3(2, 2, 2);
                break;
            case Difficulty.HARD:
                GetComponent<Renderer>().material.color = Color.red;
                transform.localScale = new Vector3(1, 1, 1);
                break;
            default:
                GetComponent<Renderer>().material.color = Color.green;
                transform.localScale = new Vector3(3, 3, 3);
                break;
        }


        #region Old Code    
        //if(difficulty == Difficulty.EASY)
        //{
        //    GetComponent<Renderer>().material.color = Color.green;
        //    transform.localScale = new Vector3(3, 3, 3);
        //}
        //if (difficulty == Difficulty.MEDIUM)
        //{
        //    GetComponent<Renderer>().material.color = Color.blue;
        //    transform.localScale = new Vector3(2, 2, 2);
        //}
        //if (difficulty == Difficulty.HARD)
        //{
        //    GetComponent<Renderer>().material.color = Color.red;
        //    transform.localScale = new Vector3(1, 1, 1);
        //}
        #endregion

    }
}
