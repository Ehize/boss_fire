using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossObject : MonoBehaviour
{
    public Boss boss;

    public TMP_Text nameTxt;
    public TMP_Text maxHealthTxt;

    // Start is called before the first frame update
    void Start ()
    {
        CreateBossInfo();	
	}

    public void CreateBossInfo()
    {
        nameTxt.text = boss.name;
        maxHealthTxt.text = "Health" + boss.maxHealth;
    }
}
