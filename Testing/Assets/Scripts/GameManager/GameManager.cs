using System;
using Bridge;
using Composite;
using Decorator;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _ironMan;
    [SerializeField] private Transform _spawnPoint1;
    [SerializeField] private Rigidbody _rigidbody;

    /*
    [SerializeField] private Transform _spawnPoint1;
    [SerializeField] private Transform _spawnPoint2;
    [SerializeField] private Transform _spawnPoint3;
    [SerializeField] private GameObject _soldierPrefab;
    */
    
    /*private void Start()
    {
        SuperHero ironMan = new Tony(_ironMan, _spawnPoint1); // Базовый объект
        SuperHero mark42IronMan = new Mark42(ironMan, _rigidbody); // Декоратор

        mark42IronMan.Operation(); 
        /*Soldier soldier = new Soldier("Frank", _spawnPoint1.position, _soldierPrefab);
        Soldier soldier2 = new Soldier("Bobby", _spawnPoint2.position, _soldierPrefab);
        
        Squad squad = new Squad();
        squad.Add(soldier);
        squad.Add(soldier2);
        
        Squad bigSquad = new Squad();
        bigSquad.Add(squad);
        bigSquad.Add(new Soldier("Artur", _spawnPoint3.position,_soldierPrefab));#1#
        
    }*/

    private void Update()
    {
        SuperHero ironMan = new Tony(_ironMan, _spawnPoint1); // Базовый объект
        SuperHero mark42IronMan = new Mark42(ironMan, _rigidbody); // Декоратор

        mark42IronMan.Operation();
    }
}
