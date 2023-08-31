using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField, Header("配置するブロック")]
    GameObject[] _blocks;

    [SerializeField, Header("縦列のブロックの個数")]
    int _colBlocks;

    [SerializeField, Header("横列のブロックの個数")]
    int _rowBlocks;

    void InstantiateBlocks(int col, int row)
    {

    }
}
