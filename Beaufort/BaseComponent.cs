﻿namespace Beaufort
{
  public abstract class BaseComponent : IComponent
  {
    //-------------------------------------------------------------------------

    public string Name { get; private set; } = "Unnamed Component";

    //-------------------------------------------------------------------------

    public bool SetName( string name )
    {
      if( name.Length > 0 )
      {
        Name = name;

        return true;
      }

      return false;
    }

    //-------------------------------------------------------------------------    
  }
}
