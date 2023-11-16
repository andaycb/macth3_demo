using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ItemInfoSO", menuName = "ScriptableObjects/ItemInfoSO", order = 1)]
public class ItemInfoSO : ScriptableObject
{
    [SerializeField] private ItemInfo[] itemInfos;

    public Sprite GetSprite(NormalItem.eNormalType eNormalType)
    {
        Sprite sprite = null;

        for (int i = 0; i < itemInfos.Length; i++)
        {
            if (itemInfos[i].eNormalType == eNormalType)
            {
                sprite = itemInfos[i].spriteItem;
                break;
            }
        }
        return sprite;
    }
}

[Serializable]
public class ItemInfo
{
    public NormalItem.eNormalType eNormalType;
    public Sprite spriteItem;
}