using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName ="CreatManagerVarsContainer")]
public class ManagerVars : ScriptableObject
{

    public static ManagerVars GetManagerVars()
    {
       return Resources.Load<ManagerVars>("ManagerVarsContainer");
    }
    public List<Sprite> bgThemeSpriteList = new List<Sprite>();
    public float nextXPos = 5.54f;
    public float nextYPos = 6.66f;

    public GameObject NormalPlatFormPre;
    public GameObject characterPre;
}
