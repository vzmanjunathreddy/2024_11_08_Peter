//Suppose you have a performance-critical C# application that
//frequently creates and disposes of short-lived objects.
//Implement an object pool to reuse objects instead of creating new instances,
//which can reduce memory allocations and improve performance.

using System.Diagnostics;

using Task3;

var pool = new ObjectPool<ComplexType>();

var obj1 = pool.GetInstance();
var obj2 = pool.GetInstance();

Debug.Assert(obj1 != obj2);

pool.Release(obj1);
var obj3 = pool.GetInstance();
Debug.Assert(obj3 == obj1);