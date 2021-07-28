using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MetaActionDialog 
{
    [TextArea(3, 10)]
    public string sentences;

    public UnityEvent Action;
}
