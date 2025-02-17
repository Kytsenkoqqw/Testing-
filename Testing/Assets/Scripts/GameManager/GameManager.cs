using System;
using Composite;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Vector3 _offset = new Vector3(5,0,0);
    [SerializeField] private GameObject _soldierPrefab;
    
    private void Start()
    {
        Soldier soldier = new Soldier("Frank", _spawnPoint.position, _soldierPrefab);
        Soldier soldier2 = new Soldier("Bobby", _spawnPoint.position + _offset, _soldierPrefab);
        
        Squad squad = new Squad();
        squad.Add(soldier);
        squad.Add(soldier2);
        
        Squad bigSquad = new Squad();
        bigSquad.Add(squad);
        bigSquad.Add(new Soldier("Artur", new Vector3(-5,0,0),_soldierPrefab));
        
        bigSquad.Move(new Vector3(8,0,8));
    }
}
