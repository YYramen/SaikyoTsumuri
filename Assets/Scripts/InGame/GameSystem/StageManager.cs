using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField, Header("�z�u����u���b�N")]
    GameObject[] _blocks;

    [SerializeField, Header("�c��̃u���b�N�̌�")]
    int _colBlocks;

    [SerializeField, Header("����̃u���b�N�̌�")]
    int _rowBlocks;

    void InstantiateBlocks(int col, int row)
    {

    }
}
