using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] jellyGoldList;

    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAc;

    public void ChangeAc(Animator anim, int level)
    {
        // level은 1부터 시작하므로 1을 빼주어야 index에 맞음
        anim.runtimeAnimatorController = LevelAc[level - 1];
    }
}
