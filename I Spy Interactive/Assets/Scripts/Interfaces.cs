using UnityEngine;
using UnityEngine.Events;

public interface IRun
{
    void Run( );
}

public interface ITest
{
    void Test();
}

public interface IListen
{
    UnityEvent Event { get; set; }
    IRun NewIRunObj { get; set; }
    void Start();
}

public interface ITrigger
{
    void OnTriggerEnter(Collider obj);
}

public interface IMove
{
    Vector3 location { get; set; }
    void Move(CharacterController controller);
}
