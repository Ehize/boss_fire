using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Boss", menuName = "Boss")]
public class Boss : ScriptableObject
{
    public new string name;
    public int maxHealth;
   
}
