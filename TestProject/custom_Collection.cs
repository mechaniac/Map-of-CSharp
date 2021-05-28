using System.Collections.Generic;
using System.Collections;

public class Col : IEnumerable<E>
{
    private List<E> _es = new List<E>();

    public void Add(E e)
    {
        _es.Add(e);
    }

    public IEnumerator<E> GetEnumerator()
    {
        return new E_Enumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


    public E this[int idx] => _es[idx];
    public int Count => _es.Count;
}

public class E_Enumerator : IEnumerator<E>
{
    private Col _c;
    private int _i;

    public E_Enumerator(Col c)
    {
        _c = c;
        _i = -1;
    }

    public E Current => _c[_i];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        return ++ _i < _c.Count;
    }

    public void Reset()
    {
        _i = -1;
    }
}

public class E
{
    public int id { get; set; }
    public string? n { get; set; }

    public override string ToString()
    {
        return $"{id} ({n})";
    }
}